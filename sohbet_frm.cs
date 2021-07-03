using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Proje_Ödevi
{
    public partial class sohbet_frm : Form
    {
        public string Kullanici_adi;
    
        public sohbet_frm()
        {
            InitializeComponent();
        }
        
        private void sohbet_frm_Load(object sender, EventArgs e)
        {
            kullanici_cmb.Visible = false;
         
            if (Kullanici_adi=="admin")
            {
                oleDbConnection1 = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "/Veri_Tabani.mdb");
                oleDbDataAdapter1 = new OleDbDataAdapter("select kimden,kime,mesaj,tarihsaat from mesajlar", oleDbConnection1);
                oleDbDataAdapter1.Fill(dataSet1, "mesajlar");
                dataView1.Table = dataSet1.Tables[0];
                dataView1.Sort = "tarihsaat";
                urunlistele.DataSource = dataView1;
               //kullanıci_cmb comboBox için kullanıcı adlarının çekilmesi
                kullanici_cmb.Visible = true;
               OleDbConnection baglan=new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "/Veri_Tabani.mdb");
               baglan.Open();
                OleDbCommand kullaniciekle = new OleDbCommand("select KullaniciAdi from Kullanici", baglan);
                OleDbDataReader oku = kullaniciekle.ExecuteReader();
               while(oku.Read())
               {
                   kullanici_cmb.Items.Add(oku["KullaniciAdi"].ToString());
               }
               baglan.Close();
                
            }
            else
            {
                
                oleDbConnection1 = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "/Veri_Tabani.mdb");
                oleDbDataAdapter1 = new OleDbDataAdapter("select kimden,kime,mesaj,tarihsaat from mesajlar", oleDbConnection1);
                oleDbDataAdapter1.Fill(dataSet1, "mesajlar");
                dataView1.Table = dataSet1.Tables[0];
                dataView1.RowFilter = "kimden='" + Kullanici_adi + "' or kime='" + Kullanici_adi + "'";
                dataView1.Sort = "tarihsaat";
                urunlistele.DataSource = dataView1;
            }
           
        }
        

        private void gonder_Click(object sender, EventArgs e)
        {
            if (Kullanici_adi == "admin")
            {
                DataRow ekle;
                OleDbCommandBuilder cb = new OleDbCommandBuilder(oleDbDataAdapter1);
                ekle = dataSet1.Tables[0].NewRow();
                ekle["kimden"] = Kullanici_adi;
                ekle["kime"] = kullanici_cmb.Text;
                ekle["mesaj"] = mesaj_txt.Text;
                ekle["tarihsaat"] = DateTime.Now.ToString();
                dataSet1.Tables[0].Rows.Add(ekle);
                oleDbDataAdapter1.Update(dataSet1, "mesajlar");
                urunlistele.DataSource = dataView1;
                mesaj_txt.Text = "";
            }
            else
            {
                DataRow ekle;
                OleDbCommandBuilder cb = new OleDbCommandBuilder(oleDbDataAdapter1);
                ekle = dataSet1.Tables[0].NewRow();
                ekle["kimden"] = Kullanici_adi;
                ekle["kime"] = "admin";
                ekle["mesaj"] = mesaj_txt.Text;
                ekle["tarihsaat"] = DateTime.Now.ToString();
                dataSet1.Tables[0].Rows.Add(ekle);
                oleDbDataAdapter1.Update(dataSet1, "mesajlar");
                urunlistele.DataSource = dataView1;
                mesaj_txt.Text = "";
            }
         }

        private void geri_don_Click(object sender, EventArgs e)
        {
            if (Kullanici_adi == "admin")
            {
                admin_frm admin_geri_git = new admin_frm();
                admin_geri_git.Kullanici_adi = Kullanici_adi;
                admin_geri_git.Show();
                this.Hide();
            }
            else
            {
                ana_fr gerigit = new ana_fr();
                gerigit.Kullanici_adi = Kullanici_adi;
                gerigit.Show();
                this.Hide();
            }
        }
    }
}
