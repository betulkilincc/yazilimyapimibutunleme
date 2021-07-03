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
    public partial class alim_satim_grafik : Form
    {
        public string Kullanici_adi;
        public alim_satim_grafik()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        int durum, durum_2;
        double satis_toplam = 0,alis_toplam=0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ilk = Convert.ToDateTime(baslangic_tarih.Text);
            DateTime son = Convert.ToDateTime(bitis_tarih.Text);
            //baglantiyi aciyoruz
            baglanti.Open();
            //İslemler tablosunun girilen değerlere göre okuyoruz
            OleDbCommand komut = new OleDbCommand("select * from İslemler", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                //girilen tarihler ile verideki tarihleri kıyaslıyoruz
                durum = DateTime.Compare(Convert.ToDateTime(oku["islemTarih"].ToString()), ilk);
                durum_2 = DateTime.Compare(Convert.ToDateTime(oku["islemTarih"].ToString()), son);
                //eger ilk tarih girilen tarihden büyükse ve son tarih girilen tarihden küçükse bu islem istenilen tarihler arasındadır
                double miktar=0;
                if (durum >= 0 && durum_2 <= 0 && oku["İslemTuru"].ToString()=="Alis")
                {
                    miktar=Convert.ToDouble(oku["UrunFiyat"]) * Convert.ToDouble(oku["UrunMiktar"]);
                    alis_toplam += miktar;
                }
                if (durum >= 0 && durum_2 <= 0 && oku["İslemTuru"].ToString() == "Satis")
                {
                    miktar = Convert.ToDouble(oku["UrunFiyat"]) * Convert.ToDouble(oku["UrunMiktar"]);
                    satis_toplam += miktar;
                }
            }
           
            int alis_satis_toplam =Convert.ToInt32(alis_toplam) + Convert.ToInt32(satis_toplam);
            double alis_oran = (alis_toplam / alis_satis_toplam) * 360;
            double satis_oran = (satis_toplam / alis_satis_toplam) * 360;
            double alis_yuzde = (alis_toplam / alis_satis_toplam) * 100;
            double satis_yuzde = (satis_toplam / alis_satis_toplam) * 100;

            Pen p = new Pen(Color.Black, 1);
            Graphics g = this.CreateGraphics();
            
            Rectangle  rec = new Rectangle(baslangic_tarih.Location.X + baslangic_tarih.Size.Width+75, 75, 250, 260);
            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Red);
            g.Clear(alim_satim_grafik.DefaultBackColor);
            g.DrawPie(p,rec,0,(float)alis_oran);
            g.FillPie(b1,rec,0,(float)alis_oran);
            g.DrawPie(p, rec, (float)alis_oran, (float)satis_oran);
            g.FillPie(b2, rec, (float)alis_oran, (float)satis_oran);
            alimyuzde_txt.Text = "%" + (int)alis_yuzde;
            satimyuzde_txt.Text = "%" + (int)satis_yuzde;
            alimyuzde_txt.Visible = true;
            alim_lbl.Visible = true;
            satimyuzde_txt.Visible = true;
            satim_lbl.Visible = true;
            baglanti.Close();
        }

        private void alim_satim_grafik_Load(object sender, EventArgs e)
        {
            alimyuzde_txt.Visible = false;
            alim_lbl.Visible = false;
            satimyuzde_txt.Visible = false;
            satim_lbl.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
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
