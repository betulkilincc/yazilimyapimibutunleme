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
    
    public partial class ana_fr : Form
    {
        //Giris yapan kullanicinin bilgilerini tutuyorum.
        public string Kullanici_adi;
        public string Para;
        
        public ana_fr()
        {
            InitializeComponent();
        }
        //baglantiyi kuruyorum
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //kullanıcının ürünlerini listelemek için dataTable olusturuyorum
        DataTable tablo = new DataTable();
        private void ana_fr_Load(object sender, EventArgs e)
        {
            //labela kullanıcının kullanıcı adını yazıyorum
            kullanici_lbl.Text = Kullanici_adi;
            //diger labela kullanıcının parasını yazıyorum
            para_lbl.Text = Para;
            //listeleme fonksiyonunu çagırıyoruz.
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //giris formunu açıp bu formu kapatıyoruz.
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();

        }
        public void listele()
        {
            //baglantiyi açıyorum
            baglanti.Open();
            //kUrun tablosundan kullanıcı adına gore urun bigilerini çekiyorum
            OleDbDataAdapter liste = new OleDbDataAdapter("select UrunAdi,UrunMiktar,UrunBirim from kUrun where KullaniciU = '"+Kullanici_adi+"'", baglanti);
            liste.Fill(tablo);
            urunlistele.DataSource = tablo;
            urunlistele.DefaultCellStyle.SelectionBackColor = Color.White;
            urunlistele.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();

        }
        private void para_ekle_btn_Click(object sender, EventArgs e)
        {
            //para ekleme formunu acıyorum
            para_ekle_frm para_ekle = new para_ekle_frm();
            para_ekle.Kullanici_adi = Kullanici_adi;
            para_ekle.ShowDialog();
           
            
        }
        private void cikisanasayfa_Click(object sender, EventArgs e)
        {
            //programı kapatıyorum
            Application.Exit();
        }

        private void satis_btn_Click(object sender, EventArgs e)
        {
            //satis formunu açıyorum ve gerekli bilgileri gönderiyorum
            satis_frm satis = new satis_frm();
            satis.Kullanici_adi = Kullanici_adi;
            satis.Urun_id = urunlistele.CurrentRow.Cells["UrunAdi"].Value.ToString();
            satis.ShowDialog();
            tablo.Clear();
            listele();
            
        }

        private void ürün_al_btn_Click(object sender, EventArgs e)
        {
            //satin alma formunu acıyorum ve gerekli bilgileri gönderdikden sonra bu formu kapatıyorum
            satin_al_frm ürün_al = new satin_al_frm();
            ürün_al.alici_kullanici_adi = Kullanici_adi;
            ürün_al.para = Para;
            ürün_al.Show();
            this.Hide();
        }
        private void avatar_Click(object sender, EventArgs e)
        {
            //kullanıcı formunu acıp ve gerekli bilgileri gönderdikten sonra bu formu kapatıyorum.
            hesap hesap = new hesap();
            hesap.Kullanici_adi = Kullanici_adi;
            hesap.Para = Para;
            hesap.Show();
            this.Hide();
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
