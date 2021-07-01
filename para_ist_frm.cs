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
using System.Xml;

namespace Proje_Ödevi
{
    public partial class para_ist_frm : Form
    {
        private string para;
        private double şuanki_para;
        private double total_para;
        private double istek_para;
        private string durum;
        private string filitre;
        private double tl;

        public para_ist_frm()
        {
            InitializeComponent();
        }
        //veri tabanı baglantisi kuruluyor
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //para istekleri için dataTable olusturuluyor.
        DataTable tablo = new DataTable();
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            admin_frm admingeri = new admin_frm();
            admingeri.Show();
            this.Hide();
        }

        private void admin_frm_Load(object sender, EventArgs e)
        {
            
            //listeleme fonksiyonunu çagırıyoruz
            Listeleme();

        }
        public void Listeleme()
        {
                //baglantiyi aciyoruz
                baglanti.Open();
                //Paraekle tablosunda ki bütün istekleri cekiyoruz
                OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Paraekle", baglanti);
                //olusturdugumuz listeyi dataTable'a yazdırıyoruz
                liste.Fill(tablo);
                paralisteleme.DataSource = tablo;
                paralisteleme.ReadOnly = true;
                paralisteleme.DefaultCellStyle.SelectionBackColor = Color.White;
                paralisteleme.DefaultCellStyle.SelectionForeColor = Color.Red;
                baglanti.Close();

            
        }
        public void Filitre_Liste(string durum)
        {
            //baglantyii aciyoruz
            baglanti.Open();
            //Paraekle tablosunda ki istekleri gelen duruma göre listeliyoruz
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Paraekle where Durum = '" + durum + "'", baglanti);
            //olusturdugumuz listeyi dataTable'a yazdırıyoruz
            liste.Fill(tablo);
            paralisteleme.DataSource = tablo;
            baglanti.Close();
        }

        private void onay_btn_Click(object sender, EventArgs e)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //Paraekle tablosunu duruma göre okuyoruz
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where Durum= '" + paralisteleme.CurrentRow.Cells["Durum"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            //tabloyu okudugu sürece durumları kontrol ediyoruz
            while (oku.Read())
            {
                if (oku["Durum"].ToString()=="Onaylandı")
                {
                    MessageBox.Show("Para isteği daha önce onaylamış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                }
                else if (oku["Durum"].ToString()=="Onaylanmadi")
                {
                    MessageBox.Show("Para isteği daha önce reddedilmiş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                }
                else
                {
                    //baglantiyi kapatıp parayı ekliyoruz
                    baglanti.Close();
                    Para_ekle();
                    break;

                }
            }
            //para eklemee islemi bitince tabloyu temizleyip tekrar listeliyoruz
            tablo.Clear();
            Listeleme();

        }
        private void onaylama_btn_Click(object sender, EventArgs e)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            ////Paraekle tablosunu duruma göre okuyoruz
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where Durum= '" + paralisteleme.CurrentRow.Cells["Durum"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            //tabloyu okudugu sürece durumları kontrol ediyoruz
            while (oku.Read())
            {
                if (oku["Durum"].ToString() == "Onaylandı")
                {
                    MessageBox.Show("Para isteği daha önce onaylamış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                    
                }
                else if (oku["Durum"].ToString() == "Onaylanmadi")
                {
                    MessageBox.Show("Para isteği daha önce reddedilmiş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    break;
                    
                }
                else
                {
                    //baglantyii kapatıyoruz
                    baglanti.Close();
                    //durum degiskeninini degistiroyuz
                    durum = "Onaylanmadi";
                    //gerekli degerleri alıp reddedilen istediğin durumunu güncelliyoruz
                    string istek = paralisteleme.CurrentRow.Cells["İstekPekle"].Value.ToString();
                    string kullanici = paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString();
                    Durum_güncelle(durum,istek,kullanici);
                    MessageBox.Show("Reddetme Başarılı", "Tamam");
                    break;
                    
                }
            }
            //Reddetme islemi bitince tabloyu temizleyip tekrar listeliyoruz
            tablo.Clear();
            Listeleme();

        }


        public void para_güncelle(double para)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //kullanıcının parasını güncelliyoruz
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + para.ToString() + "' where KullaniciAdi = '" + paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onaylama Başarılı", "Tamam");
        }
        public void Durum_güncelle(string durum,string istek,string kullanici)
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //para isteginin durumunu güncelliyoruz
            OleDbCommand sorgu = new OleDbCommand("update Paraekle set Durum= '" + durum + "' where İstekPekle=  '" + istek + "' and KullaniciPekle = '"+kullanici+"'", baglanti);
            sorgu.ExecuteReader();
            baglanti.Close();
            tablo.Clear();
            Filitre_Liste(filitre);
            

        }
        public void Para_ekle()
        {
            //baglantiyi aciyoruz
            baglanti.Open();
            //şeçilen değerlere göre istek parayı buluyoruz
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where İstekPekle= '" + paralisteleme.CurrentRow.Cells["İstekPekle"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                //istek parayı tablodan çekiyoruz
                para = oku["İstekPekle"].ToString();
                //istek parayı kur hesabına göre ayarlıyoruz
                tl = kur_hesabı(Int32.Parse(para),oku["KullaniciPekle"].ToString());
                //istek parayı kur hesabından gelen veriye eşitliyoruz
                istek_para = tl;
            }
            baglanti.Close();

            baglanti.Open();
            //Paraekle tablosunu şeçilen değerlere göre okuyup kullanıcnın şuan ki parasını buluyoruz
            OleDbCommand komut_2 = new OleDbCommand("Select *from Kullanici where KullaniciAdi= '" + paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku_2 = komut_2.ExecuteReader();
            while (oku_2.Read())
            {
                para = oku_2["Cuzdan"].ToString();
                şuanki_para = double.Parse(para);
                total_para = istek_para + şuanki_para;
            }
            baglanti.Close();
            //toplam parayı para güncelle fonksiyonuna gönderip parayı güncelliyoruz
            para_güncelle(total_para);
            durum = "Onaylandı";
            //istek paranın durumunu güncelliyoruz
            string istek = paralisteleme.CurrentRow.Cells["İstekPekle"].Value.ToString();
            string kullanici = paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString();
            Durum_güncelle(durum,istek,kullanici);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filitre için kontrol yapıyoruz
            if (istekler.SelectedIndex==0)
            {
                filitre = "Onaylandı";
                tablo.Clear();
                Filitre_Liste(filitre);
            }
            else if (istekler.SelectedIndex==1)
            {
                tablo.Clear();
                filitre= "Onaylanmadi";
                Filitre_Liste(filitre);
            }
            else
            {
                tablo.Clear();
                filitre = "Bekleniyor";
                Filitre_Liste(filitre);
            }
        }

        private void cikisanasayfa_Click(object sender, EventArgs e)
        {
            //uygulamadan cikis yapiyoruz
            Application.Exit();
        }
        private double kur_hesabı(int  istek_para,string kullanici)
        {
            //Kur bilgisi için siteyi tanımlıyoruz
            string kurlar = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xml = new XmlDocument();
            xml.Load(kurlar);
            //verilen değerlere göre istek paranın tipini buluyoruz
            OleDbCommand komut_2 = new OleDbCommand("Select *from Paraekle where KullaniciPekle= '" + kullanici + "' and İstekPekle= '"+istek_para.ToString()+"'", baglanti);
            OleDbDataReader oku_2 = komut_2.ExecuteReader();
            while (oku_2.Read())
            {   
                if (oku_2["ParaTip"].ToString() == "TRY")
                {
                    //Tipi türk lirasi ise aynı değeri gönderiyoruz
                    tl = istek_para;

                }
                else if (oku_2["ParaTip"].ToString() == "EUR")
                {
                    //Tipi euro ise kur bilgisini çekip parayı kurlar çarpıp gönderiyoruz
                    string euro_kur = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='EUR']/BanknoteSelling").InnerXml;
                    double euro = Convert.ToDouble(euro_kur.Replace(".", ","));
                    tl = istek_para * euro;
                    tl = Math.Round(tl, 2);
                    



                }
                else if (oku_2["ParaTip"].ToString() == "USD")
                {
                    //Tipi dolar ise kur bilgisini çekip parayı kurlar çarpıp gönderiyoruz
                    string usd_kur = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteSelling").InnerXml;
                    double usd = Convert.ToDouble(usd_kur.Replace(".", ","));
                    tl = istek_para * usd;
                    tl = Math.Round(tl, 2);
                }
                else if (oku_2["ParaTip"].ToString() == "GBP")
                {
                    //Tipi gbp ise kur bilgisini çekip parayı kurlar çarpıp gönderiyoruz
                    string gbp_kur = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='GBP']/BanknoteSelling").InnerXml;
                    double gbp = Convert.ToDouble(gbp_kur.Replace(".", ","));
                    tl = istek_para * gbp;
                    tl = Math.Round(tl, 2);
                }
            }

            //en son tlyi değer olarak gönderiyoruz
            return tl;

        }

    }
}
