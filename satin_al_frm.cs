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
    public partial class satin_al_frm : Form
    {
        //alici ve satici kullanici bilgileri
        public string alici_kullanici_adi,satici_kullanici_adi;
        //istek ürün bilgileri
        string istek_ürün, urun_birim;
        //alicinin total parası
        public string para;
        //harcanıcak para ve kalıcak para
        double harcanan_para, total_para;
        //alım bilgileri
        double istek_miktar,olan_miktar,alinan_miktar,total_miktar;
        //alinicak fiyat
        int alinan_fiyat;
        //alım kontrol
        bool alim_gerceklesti;
        //aliciya gönderilicek para
        double gonderilen_para;
        //muhasebeye gönderilicek para
        double muhasebe_ucret;
        //alinan ürünün alıcıda daha once olup olmadıgının kontrolü
        bool urunu_var = false;


        public satin_al_frm()
        {
            InitializeComponent();
        }
        //veri tabani baglantisi kuruluyor
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //alinacak ürünler listesi icin dataTable olusturuluyor
        DataTable tablo = new DataTable();
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            ana_fr ana = new ana_fr();
            ana.Kullanici_adi = alici_kullanici_adi;
            if(alim_gerceklesti)
            {
                ana.Para = total_para.ToString();
                ana.Show();
                this.Hide();

            }
            else
            {
                ana.Para = para;
                ana.Show();
                this.Hide();
            }
          
        }

        private void satin_al_frm_Load(object sender, EventArgs e)
        {
            //form yüklendiginde listeleme,kullanıcıın parasını yazdırma ve comboboxa urunlerı eklemeyi yapıyoruz.
            Listeleme();
            paraguncelle(para);
            uruntur();
           
        }
        private void paraguncelle(string para)
        {
            //gelen parayı label paraya yazdırıyoruz.
            lbl_para.Text = para;
        }
        private void Listeleme()
        {

            baglanti.Open();
            //urunler tablosundan gerekli bilgileri listeye cekiyoruz
            OleDbDataAdapter liste = new OleDbDataAdapter("select UrunAdi,UrunBirim,UrunTuru from Urunler", baglanti);
            //listeyi tabloya yazdırıyoruz.
            liste.Fill(tablo);
            //tabloyu dataTablela bastırıyoruz.
            urunlersatinal.DataSource = tablo;
            //dataTable sadece okunabilir oluyor ve veri girişi almıyor.
            urunlersatinal.ReadOnly = true;
            
            urunlersatinal.DefaultCellStyle.SelectionBackColor = Color.White;
            urunlersatinal.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
            baglanti.Close();

        }

        private void cikisanasayfa_Click(object sender, EventArgs e)
        {
            //uygulamadan cikis yapıyoruz
            Application.Exit();
        }

        private void filitre_listeleme(string uruntur)
        {
            //tabloyu temizliyoruz
            tablo.Clear();
            //baglantiyi aciyoruz
            baglanti.Open();
            //şeçilne urun turune göre verileri tekrar listeliyoruz
            OleDbDataAdapter liste1 = new OleDbDataAdapter("select UrunAdi,UrunBirim,UrunTuru from Urunler where UrunTuru= '" + uruntur + "'", baglanti);
            //listeyi dataTable'a yazdırıyoruz
            liste1.Fill(tablo);
            urunlersatinal.DataSource = tablo;
            urunlersatinal.DefaultCellStyle.SelectionBackColor = Color.White;
            urunlersatinal.DefaultCellStyle.SelectionForeColor = Color.Green;
            baglanti.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxdan şeçilen değere göre listelemeyi tekrar yapıyoruz
            for (int i = 0; i < filtre_cmbx.Items.Count; i++)
            {
                if (filtre_cmbx.SelectedIndex == i)
                {
                    filitre_listeleme(filtre_cmbx.SelectedItem.ToString());
                }
            }
        }

        private void uruntur()
        {

            //filitreme icin comboboxa veri tabanından itemler çekiliyor.
            filtre_cmbx.Items.Clear();
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from UrunTur", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                filtre_cmbx.Items.Add(oku["UrunTuru"].ToString());
            }
            baglanti.Close();
        }
        private void satin_al_piyasa_Click(object sender, EventArgs e)
        {
            //istek birim girdisi kontrol ediliyor
            if (birim.Text== "Lütfen birim giriniz")
            {
               
               MessageBox.Show("Lütfen kaç birim almak istediğinizi belirtiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //alici para bilgisi kontrol ediliyor
            else if (para == " ")
            {
                MessageBox.Show("Lütfen önce para yükleyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //fiyat belirleme formuna gidilip gerekli bilgiler gonderiliyor.
                fiyatbelirle fiyatbelirle = new fiyatbelirle();
                istek_ürün = urunlersatinal.CurrentRow.Cells["UrunAdi"].Value.ToString();
                fiyatbelirle.istek_birim = Convert.ToDouble(birim.Text.Replace(".",","));
                fiyatbelirle.alici_kullanici_adi = alici_kullanici_adi;
                fiyatbelirle.istek_ürün = istek_ürün;
                fiyatbelirle.alici_para = double.Parse(para);
                fiyatbelirle.Show();
                
            }
            

        }
        //tasarım için fare tıklaması öncesi ve sonrası için kodlar başlangıç
        private void birim_Enter(object sender, EventArgs e)
        {
            if (birim.Text == "Lütfen birim giriniz")
            {
                birim.Text = "";
                birim.ForeColor = Color.Black;
            }
        }

        

        private void birim_Leave(object sender, EventArgs e)
        {
            if (birim.Text == "")
            {
                birim.Text = "Lütfen birim giriniz";
                birim.ForeColor = Color.Silver;
            }
        }
        //tasarım için fare tıklaması öncesi ve sonrası için kodlar bitiş



        private void satın_al_btn_Click(object sender, EventArgs e)
        {
            //İstek birim girdisi kontrol ediliyor
            if (birim.Text == "Lütfen birim giriniz")
            {
                MessageBox.Show("Lütfen kaç birim almak istediğinizi belirtiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // kullanılacak değişkenlerin değerleri varsayılana dönüştürülüyor
                alim_gerceklesti = false;
                harcanan_para = 0;
                alinan_miktar = 0;
                gonderilen_para = 0;
                //istek miktarı textboxdan alıyoruz
                istek_miktar = Convert.ToDouble(birim.Text.Replace(".", ","));
                //istek ürünü datagriden alıyoruz
                istek_ürün = urunlersatinal.CurrentRow.Cells["UrunAdi"].Value.ToString();
                //baglantiyi aciyoruz
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                //isek ürün ve kullanıcının satmadığı satis listesindeki verileri küçükten büyüge sıralayıp okuyoruz
                komut.CommandText = ("Select *from Satis where UrunAdi = '" + istek_ürün + "'  AND NOT KullaniciAdi='" + alici_kullanici_adi + "' AND SatisOnay ='"+"Onaylandi"+"'ORDER BY UrunFiyat ASC");
                OleDbDataReader oku = komut.ExecuteReader();
                //tabloyu okudugu sürece kontroller yapılıyor
                while (oku.Read())
                {
                    //istek miktar olan miktardan küçükse direkt islem gerçeklesiyor
                    if (istek_miktar <= Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".",",")) && Convert.ToDouble(oku["sUrunMiktar"].ToString()) > 0)
                    {
                        alinan_fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                        gonderilen_para = istek_miktar * alinan_fiyat;
                        harcanan_para += gonderilen_para;
                        muhasebe_ucret = harcanan_para / 100;
                        harcanan_para += muhasebe_ucret;
                        satici_kullanici_adi = oku["KullaniciAdi"].ToString();
                        urun_birim = oku["UrunBirim"].ToString();

                        if (Convert.ToDouble(para.Replace(".", ",")) >= harcanan_para)
                        {
                            Para_gonder(satici_kullanici_adi, gonderilen_para);
                            Para_gonder("Muhasebe",muhasebe_ucret);
                            satistan_cikar(istek_ürün, satici_kullanici_adi, istek_miktar, alinan_fiyat);
                            islem_kayit(satici_kullanici_adi, istek_ürün, urun_birim, istek_miktar, alinan_fiyat, "Satis");
                            islem_kayit(alici_kullanici_adi, istek_ürün, urun_birim, istek_miktar, alinan_fiyat, "Alis");
                            istek_miktar += alinan_miktar;
                            alim_gerceklesti = true;
                            MessageBox.Show("Satın Alım Gerçekleştirilmiştir", "Tamam");

                            birim.Clear();
                            break;

                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz Yeterli değildir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }



                    }
                    //istek miktar olan miktardan büyükse olan miktarı satın alıp kalan miktarla islem devam ediyor
                    else if (istek_miktar > Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".",",")) && Convert.ToDouble(oku["sUrunMiktar"].ToString()) > 0)
                    {
                        alinan_miktar = Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".",","));
                        satici_kullanici_adi = oku["KullaniciAdi"].ToString();
                        alinan_fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                        gonderilen_para = alinan_miktar * alinan_fiyat;
                        harcanan_para += gonderilen_para;
                        if (Convert.ToDouble(para.Replace(".", ",")) >= harcanan_para)
                        {
                            urun_birim = oku["UrunBirim"].ToString();
                            Para_gonder(satici_kullanici_adi, gonderilen_para);
                            satistan_cikar(istek_ürün, satici_kullanici_adi, alinan_miktar, alinan_fiyat);
                            islem_kayit(satici_kullanici_adi,istek_ürün,urun_birim,alinan_miktar,alinan_fiyat,"Satis");
                            islem_kayit(alici_kullanici_adi, istek_ürün, urun_birim, alinan_miktar, alinan_fiyat, "Alis");
                            istek_miktar -= alinan_miktar;

                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz Yeterli değildir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }



                    }


                }
                //alim gerceklesirse aliciya ürünü eklenip parası çıkarılıyor
                if (alim_gerceklesti)
                {
                    urun_ekle(alici_kullanici_adi, istek_miktar.ToString(), istek_ürün, urun_birim);
                    Para_cikar(alici_kullanici_adi, harcanan_para);


                }
                else
                {
                    MessageBox.Show("İstediginiz miktarda ürün şatışda bulunmamaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                baglanti.Close();
            }
            

        }
        
        private void Para_gonder(string satici_Kullanici_adi,double gelen_para)
        {
            
            //saticinin şuan ki bulunuyor
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==satici_Kullanici_adi)
                {

                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",","));
                    break;
                }

            }
            //toplam parayı hesaplanıp kullanıcının parası güncelleniyor
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            
            

        }
        private void Para_cikar(string Kullanici_adi,double para)
        {
            //alicinin şu an ki parası bulunuyor
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
            //olan parasından harcanılan parasını çıkarıyoruz
            total_para -= para;
            //kalan parasını güncelliyoruz
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + total_para.ToString() + "' where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            //kalan parayı labela yazdırıyoruz
            paraguncelle(total_para.ToString());

            
        }
        private void urun_ekle(string Kullanici_adi,string alinan_miktar,string urunAd,string Birim)
        {
            //Onceden bu urune sahip mi kontrol ediyoruz.
            OleDbCommand sorgu = new OleDbCommand("select *from kUrun where KullaniciU='" + Kullanici_adi + "'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UrunAdi"].ToString() == urunAd)
                {
                    olan_miktar = Convert.ToDouble(oku["UrunMiktar"].ToString().Replace(".", ","));
                    total_miktar = olan_miktar + Convert.ToDouble(alinan_miktar.Replace(".", ","));
                    urunu_var = true;
                    break;
                }

            }



            if (!urunu_var)
            {
                OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
                komut.ExecuteNonQuery();
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("update kUrun set UrunMiktar = '" + total_miktar.ToString() + "' where KullaniciU ='" + Kullanici_adi + "' AND UrunAdi = '" + urunAd + "'", baglanti);
                komut.ExecuteNonQuery();
            }






        }
        private void satistan_cikar(string Urunadi,string Kullanici_Adi,double alinan_miktar,int alinan_fiyat)
        {
            //Satisdaki ürünün toplam miktarını buluyoruz
            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '"+Urunadi+"'",baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==Kullanici_Adi)
                {
                    olan_miktar = Convert.ToDouble(oku["SUrunMiktar"].ToString().Replace(".",","));
                    break;
                }
            }
            //toplam miktardan satilan miktari çıkarıyoruz ve güncelliyoruz
            olan_miktar -= alinan_miktar;
            OleDbCommand komut = new OleDbCommand("update Satis set sUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "' and UrunFiyat ='"+alinan_fiyat.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            
        }
        private void islem_kayit(string kullanici,string urun,string urun_birim,double urun_miktar,double urun_fiyat,string islem_turu)
        {
            //islemler tablosuna alis ve satis islemlerini kayit ediyoruz
            OleDbCommand komut = new OleDbCommand("insert into İslemler(KullaniciAdi,urunAdi,urunBirim,urunFiyat,urunMiktar,islemTuru,islemTarih) values('"+kullanici+"','"+urun+"','"+urun_birim+"','"+urun_fiyat.ToString()+"','"+urun_miktar.ToString()+"','"+islem_turu+"','"+ DateTime.Now.ToShortDateString()+ "')", baglanti);
            komut.ExecuteNonQuery();
        }
    }
}
