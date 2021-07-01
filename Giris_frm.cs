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

namespace Proje_Ödevi
{
    public partial class Giris_frm : Form
    {
        bool giris = false;
        public Giris_frm()
        {
            InitializeComponent();
        }
        
        //Singleton Prensibi ile tek bir baglanti kurup baglanti kurmayı bir fonksiyon olarak oluşturdum.
        private static OleDbConnection connect = new OleDbConnection();
        public static OleDbConnection baglanti_kur()
        {
            //baglantinin kurulup kurulmadıgını kontrol ediyorum.
            if (connect !=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veri_Tabani.mdb")) 
            {
                //baglanti kurulmamıssa baglantıyı kuruyorum
                connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veri_Tabani.mdb");         
            }
            //baglantı kurulduktan sonra gonderiyorum.
            return connect;
        }
        //baglantiyi kuruyorum.
        OleDbConnection baglanti = baglanti_kur();
        private void kayit_btn_Click(object sender, EventArgs e)
        {
            //kayit formunu acıp bu formu kapatıyorum
            kayit_frm kayit = new kayit_frm();
            kayit.Show();
            this.Hide();
        }
        private void gris_btn_Click(object sender, EventArgs e)
        {
            //baglantıyı açıyorum
            baglanti.Open();
            //veri tabanından kullanici tablosunu okuyorumç
            OleDbCommand sorgu = new OleDbCommand("select * from Kullanici",baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            //tabloyu okudugu sürece kontrole devam ediyorum
            while (oku.Read())
            {
                if(oku["KullaniciAdi"].ToString()== kullacini_txt.Text && oku["Parola"].ToString()== sifre_txt.Text && oku["Yetki"].ToString() =="Admin")
                {
                    //girilen bilgiler tablododan bir veriyle eşleşiyor ve yetkisi admin ise admin formunu açıyorum.
                    giris = true;
                    admin_frm admin_ana = new admin_frm();
                    admin_ana.Kullanici_adi = oku["KullaniciAdi"].ToString();
                    admin_ana.Show();
                    this.Hide();
                    break;
                }
                else if (oku["KullaniciAdi"].ToString() == kullacini_txt.Text && oku["Parola"].ToString() == sifre_txt.Text && oku["Yetki"].ToString() == "Kullanici")
                {
                    //girilen bilgiler tablodan bir veriyle eşleşiyor ve yetkisi kullanici ise kullanici ana sayfasını açıyorum.
                    giris = true;
                    ana_fr ana_Sayfa = new ana_fr();
                    ana_Sayfa.Kullanici_adi = oku["KullaniciAdi"].ToString();
                    ana_Sayfa.Para = oku["Cuzdan"].ToString();
                    ana_Sayfa.Show();
                    this.Hide();
                    break;
                }
            }
            //veri girislerinin boş oluğ olmadıgını kontrol ediyoruz.
            if (kullacini_txt.Text == "Kullanıcı-Adı" || sifre_txt.Text== "Parola")
            {
                MessageBox.Show("Kullani Adi veya şifre boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!giris)
            {
                MessageBox.Show("Kullanici Adi veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
        //tasarım için fare tıklaması öncesi ve sonrası için kodlar başlangıç
        private void kullacini_txt_Enter(object sender, EventArgs e)
        {
            if(kullacini_txt.Text=="Kullanıcı-Adı")
            {
                kullacini_txt.Text = "";
                kullacini_txt.ForeColor = Color.Black;
            }
        }
        private void kullacini_txt_Leave(object sender, EventArgs e)
        {
            if (kullacini_txt.Text == "")
            {
                kullacini_txt.Text = "Kullanıcı-Adı";
                kullacini_txt.ForeColor = Color.Silver;
            }
        }
        private void sifre_txt_Enter(object sender, EventArgs e)
        {
            if (sifre_txt.Text == "Parola")
            {
                sifre_txt.Text = "";
                sifre_txt.PasswordChar = '*';
                sifre_txt.ForeColor = Color.Black;
            }
        }

        char? passwordgiris = null;
        private void sifre_txt_Leave(object sender, EventArgs e)
        {
            if (sifre_txt.Text == "")
            {
                sifre_txt.Text = "Parola";
                sifre_txt.PasswordChar =Convert.ToChar(passwordgiris);
                sifre_txt.ForeColor = Color.Silver;
            }
        }
        //tasarım için fare tıklaması öncesi ve sonrası için kodlar bitiş
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
