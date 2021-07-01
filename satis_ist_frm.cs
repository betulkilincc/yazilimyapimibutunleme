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
    public partial class satis_ist_frm : Form
    {
        //satici kullanici bilgisi 
        string Kullanici_adi;
        //satilacak ürün bilgisi
        string Urunid;
        //satilacak ürün birimi
        string urun_birim;
        //satis durumu bilgisi 
        string durum;
        //isteninlen filitre bilgisi
        string filitre;
        //satilmak istenen fiyat alınıyor
        double Fiyat;
        //toplam miktar ve satilacak miktar bilgisi
        double total_miktar,miktar;
        //toplam para ve harcanan para bilgisi (otomatik alım için)
        double total_para, harcanan_para;
        //otomatik alım olursa muhasebe ücreti
        double muhasebe_ucret,olan_miktar;
        //satisa çıkıcak ürün miktari
        double urun_miktar;
        //alinan ürünün alıcıda daha once olup olmadıgının kontrolü
        bool urunu_var = false;
        public satis_ist_frm()
        {
            InitializeComponent();
        }

        //veri tabani baglantisi kuruluyor
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //satis istekleri icin dataTable olusturuluyor
        DataTable tablo = new DataTable();
        private void satis_ist_frm_Load(object sender, EventArgs e)
        {
            //listeleme fonksiyonunu çagırıyoruz

            listele();
        }
        private void listele()
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //Satis listesini kullanici adina göre listeliyoruz
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Satis ORDER BY KullaniciAdi ASC", baglanti);
            //listeyi DataTable'a yazdırıyoruz
            liste.Fill(tablo);
            satislisteleme.DataSource = tablo;
            satislisteleme.ReadOnly = true;
            satislisteleme.DefaultCellStyle.SelectionBackColor = Color.White;
            satislisteleme.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();
        }
        private void filitre_liste(string Satis_onay)
        {
            //Satis listesini gelen duruma göre listeliyoruz
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Satis where SatisOnay = '" + Satis_onay + "'", baglanti);
            liste.Fill(tablo);
            satislisteleme.DataSource = tablo;
            baglanti.Close();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            //admin ana formunu acip bu formu kapatıyoruz
            admin_frm ana_sayfa = new admin_frm();
            ana_sayfa.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxdan secilen degere göre filitreyi belirliyoruz
            if (filtre.SelectedIndex==0)
            {
                tablo.Clear();
                filitre = "Onaylandi";
                filitre_liste(filitre);
            }
            else if (filtre.SelectedIndex==1)
            {
                tablo.Clear();
                filitre = "Onaylanmadi";
                filitre_liste(filitre);
            }
            else
            {
                tablo.Clear();
                filitre = "Bekleniyor";
                filitre_liste(filitre);
            }
        }

        private void onay_btn_Click(object sender, EventArgs e)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //Satis tablosunu onay durumuna göre okuyoruz
            OleDbCommand komut = new OleDbCommand("select *from Satis where SatisOnay= '" + satislisteleme.CurrentRow.Cells["SatisOnay"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["SatisOnay"].ToString() == "Onaylandi")
                {
                    MessageBox.Show("Şatış isteği daha önce onaylamış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                }
                else if (oku["SatisOnay"].ToString() == "Onaylanmadi")
                {
                    MessageBox.Show("Şatış isteği daha önce reddedilmiş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                }
                else
                {
                    //gerekli değerleri veri tabanından çekiyoruz
                    Kullanici_adi = oku["KullaniciAdi"].ToString();
                    Urunid = oku["UrunAdi"].ToString();
                    Fiyat = Convert.ToDouble(oku["UrunFiyat"].ToString().Replace(".",","));
                    urun_birim = oku["UrunBirim"].ToString();
                    urun_miktar = Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".", ","));
                    durum = "Onaylandi";
                    baglanti.Close();
                    //satis isteğinin durumu güncelleniyor
                    durum_güncelle(Kullanici_adi,Urunid,Fiyat,urun_miktar,durum);
                    //Otomatik alım için kontrol ediliyor
                    Alis_istek_kntrl(Kullanici_adi,Urunid,Fiyat,urun_miktar,urun_birim);
                    MessageBox.Show("Onaylama başarılı", "Tamam");
                    break;
                }
            }

        }

        private void onaylama_btn_Click(object sender, EventArgs e)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //Satis tablosunu onay durumuna göre okuyoruz
            OleDbCommand komut = new OleDbCommand("select *from Satis where SatisOnay= '" + satislisteleme.CurrentRow.Cells["SatisOnay"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["SatisOnay"].ToString() == "Onaylandi")
                {
                    MessageBox.Show("Şatış isteği daha önce onaylamış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                }
                else if (oku["SatisOnay"].ToString() == "Onaylanmadi")
                {
                    MessageBox.Show("Şatış isteği daha önce reddedilmiş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                }
                else
                {
                    //gerekli degerleri veri tabanından cekiyoruz
                    Kullanici_adi = oku["KullaniciAdi"].ToString();
                    Urunid = oku["UrunAdi"].ToString();
                    Fiyat = Convert.ToDouble(oku["UrunFiyat"].ToString().Replace(".",","));
                    miktar = Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".", ","));
                    durum = "Onaylanmadi";
                    baglanti.Close();
                    //istegin durumu güncelleniyor
                    durum_güncelle(Kullanici_adi, Urunid,Fiyat,miktar,durum);
                    MessageBox.Show("Reddetme Başarılı", "Tamam");
                    //kullanıcıya iptal edilen ürünü tekrar veriliyor
                    ürün_iptal(Kullanici_adi, Urunid, miktar);
                    break;
                }
            }
        }
        private void durum_güncelle(string KullaniU,string Urunid,double fiyat,double miktar,string durum)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //Girilen degerlere göre satis onay durumu güncelleniyor
            OleDbCommand komut_2 = new OleDbCommand("update Satis set SatisOnay = '" + durum + "' where KullaniciAdi = '" + Kullanici_adi + "' and UrunAdi='"+Urunid+"' and UrunFiyat='"+fiyat.ToString()+"' and sUrunMiktar = '"+miktar+"'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
            //tabloyu temizliyoruz
            tablo.Clear();
            //tekrar listeliyoruz
            filitre_liste(filitre);
            

        }

        private void cikissatisistek_Click(object sender, EventArgs e)
        {
            //uygulamadan cikiyoruz
            Application.Exit();
        }

        private void ürün_iptal(string KullaniU,string Urunid,double miktar)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //kullanici adina göre kUrun tablosunu okuyoruz
            OleDbCommand komut = new OleDbCommand("select *from kUrun where KullaniciU= '" + KullaniU + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UrunAdi"].ToString()==Urunid)
                {
                    //ürün adları aynı ise olan miktarla iptal edilen miktarı topluyoruz
                    total_miktar = Convert.ToDouble(oku["UrunMiktar"].ToString().Replace(".", ","));
                    total_miktar += miktar;
                    break;
                }
            }
            //kullanicinin ürününü güncelliyoruz
            OleDbCommand komut_2 = new OleDbCommand("update kUrun set UrunMiktar = '" + total_miktar.ToString()+ "'where KullaniciU = '" + KullaniU + "' and UrunAdi='" + Urunid + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Alis_istek_kntrl(string satici,string urun,double fiyat,double satilan_miktar,string birim)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            //alis listesini girilen değerlere göre okuyoruz
            komut.CommandText = ("Select *from Alis where UrunAdi = '" + urun + "'  AND NOT KullaniciAdi='" + satici + "'ORDER BY istekFiyat ASC");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                //alis isteğindeki istek miktar yeni satisa koyulan miktardan kücükse ve eşitse
                if (Convert.ToDouble(oku["istekMiktar"].ToString().Replace(".",",")) <= satilan_miktar)
                {
                    //alis isteğindeki istek fiyat yeni satisa koyulan fiyatda büyükse ve eşitse
                    if (Convert.ToDouble(oku["istekFiyat"].ToString().Replace(".", ",")) >= fiyat)
                    {
                        //otomatik alim islemi gerçekleştiriliyor
                        satilan_miktar = Convert.ToDouble(oku["istekMiktar"].ToString().Replace(".", ","));
                        istek_alim(satici, oku["KullaniciAdi"].ToString(), urun, fiyat, satilan_miktar, birim);

                    }

                    

                }
                
            }
            baglanti.Close();

        }
        private void istek_alim(string satici,string alici,string urun,double fiyat,double miktar,string birim)
        {
            //Kullanici adina göre aliicinin değerlerini Kullanici tablosundan çekiyoruz
            OleDbCommand sorgu = new OleDbCommand("select *from Kullanici where KullaniciAdi ='"+alici+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                //alinicinin parası kontrol ediliyor
                if ((fiyat*miktar)<=Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",",")))
                {
                    //Satıcıya parası gönderiliyor.
                    Para_gonder(satici,(miktar*fiyat));
                    //islemlerle saticinin islemi ekleniyor
                    islem_kayit(satici,urun,birim,miktar,fiyat,"Satis");
                    islem_kayit(alici, urun, birim,miktar, fiyat, "Alis");
                    //muhasebe ücreti hesaplanıyor
                    muhasebe_ucret = (fiyat * miktar) / 100;
                    //muhasebe ücreti gönderiliyor.
                    Para_gonder("Muhasebe", muhasebe_ucret);
                    //alıcıdan toplam harcanan para hesaplanıyor.
                    harcanan_para = (fiyat*miktar) + muhasebe_ucret;
                    //Alıcının parası güncelleniyor.
                    Para_cikar(alici, harcanan_para);
                    //satılan ürün satış listesinden çıkarılıyor.
                    satistan_cikar(urun,satici,miktar,fiyat);
                    //alınan ürün alıcının hesabına aktarılıyor.
                    urun_ekle(alici, miktar.ToString(), urun,birim);
                    //bekleme listesinden istegi kaldırıyoruz.
                    alis_sil(alici,urun,miktar);
                }
            }


        }
        private void Para_gonder(string satici_Kullanici_adi, double gelen_para)
        {

            //saticinin şuan ki parası kontrol ediliyor
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
            //şuan ki parası ile gelen para toplanıp parası güncelleniyor
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();



        }
        private void Para_cikar(string Kullanici_adi, double giden_para)
        {

            //alicinin şuan ki parası kontrol ediliyor
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_adi)
                {
                    
                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".", ","));
                    break;
                }

            }
            //şuan ki parasından harcanan parası çıkarılıyor ve  parası güncelleniyor
            total_para -= giden_para;
            //yenipara = total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + total_para.ToString() + "' where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            
        }
        private void urun_ekle(string Kullanici_adi, string alinan_miktar, string urunAd, string Birim)
        {
            //Onceden bu urune sahip mi kontrol ediyoruz.
            OleDbCommand sorgu = new OleDbCommand("select *from kUrun where KullaniciU='"+Kullanici_adi+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UrunAdi"].ToString() == urunAd)
                {
                    olan_miktar = Convert.ToDouble(oku["UrunMiktar"].ToString().Replace(".",","));
                    total_miktar = olan_miktar + Convert.ToDouble(alinan_miktar.Replace(".", ","));
                    urunu_var = true;
                    break;
                }

            }



            if (!urunu_var)
            {   //urunu varsa toplam miktarı güncelleniyor
                OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
                komut.ExecuteNonQuery();
            }
            else
            { 
                //yeni kayit yapılıyor
                OleDbCommand komut = new OleDbCommand("update kUrun set UrunMiktar = '" + total_miktar.ToString() + "' where KullaniciU ='" + Kullanici_adi + "' AND UrunAdi = '" + urunAd + "'", baglanti);
                komut.ExecuteNonQuery();
            }
            
        }
        private void satistan_cikar(string Urunadi, string Kullanici_Adi, double alinan_miktar, double alinan_fiyat)
        {
            //saticinin satisda ki miktarı kontrol ediliyor
            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '" + Urunadi + "'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_Adi)
                {
                    olan_miktar = Convert.ToDouble(oku["SUrunMiktar"].ToString().Replace(",",","));
                    break;
                }
            }
            //kalan miktarı güncelleniyor
            olan_miktar -= alinan_miktar;
            OleDbCommand komut = new OleDbCommand("update Satis set sUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "' and UrunFiyat ='" + alinan_fiyat.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();

        }
        private void alis_sil(string kullanici_adi,string urun,double istek_miktar)
        {
            //Alis islemi gerçekleştiği için istek listeden siliniyor
            OleDbCommand komut = new OleDbCommand("delete from  Alis where KullaniciAdi = '" + kullanici_adi + "' and UrunADi = '" + urun + "' and istekMiktar = '" + istek_miktar.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();

        }
        private void islem_kayit(string kullanici, string urun, string urun_birim, double urun_miktar, double urun_fiyat, string islem_turu)
        {
            //Gerçekleştirilen islem kayit ediliyor
            OleDbCommand komut = new OleDbCommand("insert into İslemler(KullaniciAdi,urunAdi,urunBirim,urunFiyat,urunMiktar,islemTuru,islemTarih) values('" + kullanici + "','" + urun + "','" + urun_birim + "','" + urun_fiyat.ToString() + "','" + urun_miktar.ToString() + "','" + islem_turu + "','" + DateTime.Now.ToShortDateString() + "')", baglanti);
            komut.ExecuteNonQuery();
        }


    }
}
