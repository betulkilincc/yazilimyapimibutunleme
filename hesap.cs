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
    public partial class hesap : Form
    {
        //giriş yapan kullanıcının bilgileri 
        public string Kullanici_adi;
        public string Para;
        //baglantıyı kuruyoruz
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //kullanıcının bilgilerini listelemek icin dataTable olusturuyoruz.
        DataTable tablo = new DataTable();
        public hesap()
        {
            InitializeComponent();
        }

        private void gerihesap_Click(object sender, EventArgs e)
        {
            //ana formu acıp bu formu kapatıyoruz
            ana_fr ana = new ana_fr();
            ana.Kullanici_adi = Kullanici_adi;
            ana.Para = Para;
            ana.Show();
            this.Hide();
        }

        private void rapor_Click(object sender, EventArgs e)
        {
            //rapor formunu acıp bu formu kapatıyoruz
            rapor rapor = new rapor();
            rapor.Kullanici_adi = Kullanici_adi;
            rapor.Para = Para;
            rapor.Show();
            this.Hide();
        }

        private void cikishesap_Click(object sender, EventArgs e)
        {
            //uygulamıyı kapatıyoruz
            Application.Exit();
        }

        private void hesap_Load(object sender, EventArgs e)
        {
            //labela kullanıcının kullanıcı adını yazıyoruz
            kullanici_lbl.Text = Kullanici_adi;
            //diğer labela kullanıcının parasını yazıyoruz
            para_lbl.Text = Para;
            //listeleme fonksiyonunu çalıştırıyoruz.
            listele();
        }
        public void listele()
        {
            //baglanti acıyoruz
            baglanti.Open();
            //Kullanici tablosundan kullanıcı adına göre istedigimiz degerleri çagırıyoruz
            OleDbDataAdapter liste = new OleDbDataAdapter("select Ad,Soyad,Parola,TC,ePosta,Adres,Telefon from Kullanici where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            
            //gelen listeyi dataTable'a yazdırıyoruz
            liste.Fill(tablo);
            kullanicibilgileri.DataSource = tablo;
            kullanicibilgileri.DefaultCellStyle.SelectionBackColor = Color.White;
            kullanicibilgileri.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();

        }
    }
}
