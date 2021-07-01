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
     
    public partial class admin_frm : Form
    {
        //toplam kullanıcı sayısının bilgisi
        public int Kullanici_sayi;
        public string Kullanici_adi;
        public admin_frm()
        {
            InitializeComponent();
        }
        //baglantımızı kuruyoruz
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //kullanıcıları listelemek icin dataTable olusturuyoruz.
        DataTable tablo = new DataTable();
        private void para_list_btn_Click(object sender, EventArgs e)
        {
            //para istekleri formunu açıp bu formu kapatıyorum.
            para_ist_frm admin_sayfa = new para_ist_frm();
            admin_sayfa.Show();
            this.Hide();
        }
        public void listele()
        {
            
            //baglantiyi acip Kullanici tablosunda ki yetkisi kullanici olan verileri listeliyorum.
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select * from Kullanici where Yetki='" + "Kullanici" + "'", baglanti);
      
            liste.Fill(tablo);
            tumkullanicilar.DataSource = tablo;
            tumkullanicilar.DefaultCellStyle.SelectionBackColor = Color.White;
            tumkullanicilar.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();

        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            //giris formunu açığ bu formu kapatıyorum.
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();

        }

        private void satis_btn_Click(object sender, EventArgs e)
        {
            //satis istekleri formunu açıp bu formu kapatıyorum.
            satis_ist_frm satis = new satis_ist_frm();
            satis.Show();
            this.Hide();
        }

        private void admin_frm_Load(object sender, EventArgs e)
        {
            //baglantiyi açip toplam kullanici sayisini buluyorum.
            baglanti.Open();
            OleDbCommand kullanicisay = new OleDbCommand("SELECT COUNT(*) AS ToplamKayit FROM Kullanici WHERE Yetki='"+ "Kullanici" +"'", baglanti);

            OleDbDataReader oku = kullanicisay.ExecuteReader();
             if (oku.Read())
             {
                 
                 kullanici_sayisi.Text = oku["ToplamKayit"].ToString();
             }
            baglanti.Close();
            //listeleme fonksiyonunu çalıştırıyorum.
            listele();
        }

        private void cikisadmin_Click(object sender, EventArgs e)
        {
            //programı kapatıyorum.
            Application.Exit();

            
        }

        private void sohbet_btn_Click(object sender, EventArgs e)
        {
            sohbet_frm sohbet = new sohbet_frm();
            sohbet.Kullanici_adi = Kullanici_adi;
            sohbet.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alim_satim_grafik grafik = new alim_satim_grafik();
            grafik.Kullanici_adi = Kullanici_adi;
            grafik.Show();
            this.Hide();
        }

       
        
    }
}
