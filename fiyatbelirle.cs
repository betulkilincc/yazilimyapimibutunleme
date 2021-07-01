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
    public partial class fiyatbelirle : Form
    {
        //satın al forumdan gerekli değişkenleri alıyoruz.
        public double istek_birim;
        public string istek_ürün;
        public string alici_kullanici_adi;
        public double alici_para;
        //Satın alım işlemi için gerekli değişkenleri alıyoruz.
        double istek_fiyat;
        double total_para;
        double muhasebe_ücret;
        double harcanan_para;
        double olan_miktar;
        //alinan ürünün alıcıda daha once olup olmadıgının kontrolü
        bool urunu_var = false;
        double total_miktar;
        public fiyatbelirle()
        {
            InitializeComponent();
        }
        // veri tabanı baglantimizi kuruyoruz. 
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        private void cikisfiyatbelirle_Click(object sender, EventArgs e)
        {
            //satin alma formunu açıyorum ve gerekli bilgileri gönderikten sonra bu formu kpatıyorum.
            satin_al_frm satin_al = new satin_al_frm();
            satin_al.para = alici_para.ToString();
            satin_al.alici_kullanici_adi = alici_kullanici_adi;
            satin_al.Show();
            this.Hide();
            satin_al.Hide();

        }
        private void fiyatbelirle_btn_Click(object sender, EventArgs e)
        {
            //Alicin değer girip girilmediği kontrol ediliyor
            if (fiyatb_txt.Text == "")
            {
                MessageBox.Show("Lütfen istediğiniz fiyatı giriniz!", "Tamam");

            }
            //Alıcının bakiyesi kontrol ediliyor
            else if (alici_para < (istek_birim * Convert.ToDouble(fiyatb_txt.Text.Replace(".",","))))
            {
                MessageBox.Show("Bakiyeniz yetersizdir", "Para Yükle");
                satin_al_frm satin_al = new satin_al_frm();
                satin_al.para = alici_para.ToString();
                satin_al.alici_kullanici_adi = alici_kullanici_adi;
                satin_al.Show();
                this.Hide();
                
            }
            //bakiyesi yeterli oldugu durumda satış kontrol işlemi başlıyor.
            else
            {
                istek_fiyat = Convert.ToDouble(fiyatb_txt.Text.Replace(".",","));
                satis_kntrl(istek_fiyat, alici_kullanici_adi, istek_ürün, istek_birim);
                satin_al_frm satin_al = new satin_al_frm();
                satin_al.Hide();
            }

        }
        public void satis_kntrl(double istek_fiyat, string alici, string ürün, double istek_miktar)
        {
            //Satis listesinde istek miktar ve istek fiyatda ürünün kontrolü yapılıyor
            bool satisda_var = false;
            OleDbCommand komut = new OleDbCommand();
            //satis listesi listeleniyor ve kontrol yapılıyor
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = ("Select *from Satis where UrunAdi = '" + ürün + "'  AND NOT KullaniciAdi='" + alici + "'ORDER BY UrunFiyat ASC");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (istek_fiyat >= Convert.ToDouble(oku["UrunFiyat"].ToString().Replace(".",",")))
                {
                    if (istek_miktar < Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".",",")))
                    {
                        //istek miktar ve istek fiyatda ürün olduğu için satın alım gerçekleşiyor.
                        //Satıcıya parası gönderiliyor.
                        Para_gonder(oku["KullaniciAdi"].ToString(),(Int32.Parse(oku["UrunFiyat"].ToString()) * istek_miktar));
                        //muhasebe ücreti hesaplanıyor
                        muhasebe_ücret = (Int32.Parse(oku["UrunFiyat"].ToString()) * istek_miktar) / 100;
                        //muhasebe ücreti gönderiliyor.
                        Para_gonder("Muhasebe", muhasebe_ücret);
                        //alıcıdan toplam harcanan para hesaplanıyor.
                        harcanan_para = (Int32.Parse(oku["UrunFiyat"].ToString()) * istek_miktar) + muhasebe_ücret;
                        //Alıcının parası güncelleniyor.
                        Para_cikar(alici, harcanan_para);
                        //satılan ürün satış listesinden çıkarılıyor.
                        satistan_cikar(ürün, oku["KullaniciAdi"].ToString(),istek_miktar,Int32.Parse(oku["UrunFiyat"].ToString()));
                        //alınan ürün alıcının hesabına aktarılıyor.
                        urun_ekle(alici, istek_miktar, ürün, oku["UrunBirim"].ToString());
                        //Satin alım işlemi tamam.
                        MessageBox.Show("Satın alım işlemi gerçekleştirildi", "Alım Gerçekleşti!");
                        satisda_var = true;
                        satin_al_frm satin_al = new satin_al_frm();
                        satin_al.para = alici_para.ToString();
                        satin_al.alici_kullanici_adi = alici_kullanici_adi;
                        satin_al.Show();
                        this.Hide();
                        satin_al.Hide();
                    }
                }


            }
            baglanti.Close();
            //istek miktar ve istek fiyatda ürün olmadıgı için satın alma beklemeye alınıyor.
            if (!satisda_var)
            {
                Beklemeye_al(alici, istek_fiyat, istek_miktar, ürün);
            }



        }

        private void Beklemeye_al(string alici, double istek_fiyat, double istek_miktar, string ürün)
        {
            //istek alis isteme Alis tablosuna kaydediliyor
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Alis(KullaniciAdi,UrunAdi,istekMiktar,istekFiyat) values('" + alici + "','" + ürün + "','" + istek_miktar.ToString() + "','" + istek_fiyat.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Alış isteği beklemeye alınmıştır!", "Tamam");
            satin_al_frm satin_al = new satin_al_frm();
            satin_al.para = alici_para.ToString();
            satin_al.alici_kullanici_adi = alici_kullanici_adi;
            satin_al.Show();
            this.Hide();
            satin_al.Hide();
        }
        private void Para_gonder(string satici_Kullanici_adi, double gelen_para)
        {
            //satis islemi gerceklestigi icin saticinin suanki parası bulunuyor.
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == satici_Kullanici_adi)
                {

                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",","));
                    break;
                }

            }
            //su an ki parası ile kazandıgı para toplanıp güncel parası güncelleniyor.
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();



        }
        private void Para_cikar(string Kullanici_adi, double giden_para)
        {
            //satis islemi gerceklestigi icin alicinin suan ki parası bulunuyor
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_adi)
                {

                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",","));
                    break;
                }

            }
            //suan ki parasindan harcadıgı para cıkarılıp parası güncelleniyor
            total_para -= giden_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + total_para.ToString() + "' where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            alici_para = total_para;



        }
        private void urun_ekle(string Kullanici_adi, double alinan_miktar, string urunAd, string Birim)
        {

            //Onceden bu urune sahip mi kontrol ediyoruz.
            OleDbCommand sorgu = new OleDbCommand("select *from kUrun where KullaniciU='" + Kullanici_adi + "'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UrunAdi"].ToString() == urunAd)
                {
                    olan_miktar = Convert.ToDouble(oku["UrunMiktar"].ToString().Replace(".", ","));
                    total_miktar = olan_miktar + alinan_miktar;
                    urunu_var = true;
                    break;
                }

            }


            //urunu var ise toplma urunu guncelliyoruz.
            if (!urunu_var)
            {
                OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
                komut.ExecuteNonQuery();
            }
            //urnu yok ise yeni kayıt ile ürünü kaydediyoruz
            else
            {
                OleDbCommand komut = new OleDbCommand("update kUrun set UrunMiktar = '" + total_miktar.ToString() + "' where KullaniciU ='" + Kullanici_adi + "' AND UrunAdi = '" + urunAd + "'", baglanti);
                komut.ExecuteNonQuery();
            }
        }
        private void satistan_cikar(string Urunadi, string Kullanici_Adi, double alinan_miktar, int alinan_fiyat)
        {
            //gelen verilere göre kullanıcının satısta olan urununden satılan miktarı cıkarıyoruz
            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '" + Urunadi + "'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_Adi)
                {
                    olan_miktar = Convert.ToDouble(oku["SUrunMiktar"].ToString().Replace(".",","));
                    break;
                }
            }

            olan_miktar -= alinan_miktar;
            //daha sonra kalan mıktarı guncelliyoruz
            OleDbCommand komut = new OleDbCommand("update Satis set sUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "' and UrunFiyat ='" + alinan_fiyat.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();

        }

    } 
}
