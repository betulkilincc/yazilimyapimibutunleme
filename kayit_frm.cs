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
    public partial class kayit_frm : Form
    {
        //kayitin kontrolü için değişkenler
        bool kayit_yapildi = true;
        bool kullani_adi_yok = true;
        public kayit_frm()
        {
            InitializeComponent();
        }
        //baglantiyi kuruyoruz.
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        private void kayit_btn_Click(object sender, EventArgs e)
        {
            //textboxların boş olup olmadıgını kontrol ediyoruz
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    if (Controls[i].Text=="Ad" || Controls[i].Text == "Soyad" || Controls[i].Text == "Kullanıcı-Adı" || Controls[i].Text == "Parola" || Controls[i].Text == "Parola-Tekrar" || Controls[i].Text == "TC" || Controls[i].Text == "E-mail" || Controls[i].Text == "Adres" || Controls[i].Text == "Telefon")
                    {
                        MessageBox.Show("Eksik Bilgi Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kayit_yapildi = false;
                        break;
                     
                    }

                }
                else
                {
                   
                    kayit_yapildi = true;
                }
                
            }
            //daha önce boyle bir kullanıcı adı  olup olmadıgını kontrol ediyoruz
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (kullanici_adi.Text == oku["KullaniciAdi"].ToString())
                {
                    MessageBox.Show("Kullanici Adi Kullanılmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kullani_adi_yok = false;
                    baglanti.Close();
                    break;
                    
                }
                else
                {
                    kullani_adi_yok = true;
                    baglanti.Close();
                    break;
                }
            }
            //Şifre ile Şifre tekrarın aynı olup olmadığını kontrol ediyoruz
            if (sifre.Text != sifretekrar.Text)
            {

                MessageBox.Show("Sifreler aynı degil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();

            }
            else
            {


                //girilen değerler şartlara uyuyorsa kullanıcıyı kaydediyoruz
                if (kayit_yapildi && kullani_adi_yok)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Kullanici(Ad,Soyad,KullaniciAdi,Parola,ParolaTekrar,TC,ePosta,Adres,Telefon) values('" + ad.Text + "','" + soyad.Text + "','" + kullanici_adi.Text + "','" + sifre.Text + "','" + sifretekrar.Text + "','" + tc.Text + "','" + email.Text + "','" + adres.Text + "','" + telefon.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Giris_frm giris = new Giris_frm();
                    giris.Show();
                    this.Hide();
                }

            }

            
            
        }

        private void cikiskayit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //tasarım için fare tıklaması öncesi ve sonrası için kodlar başlangıç
        private void ad_Enter(object sender, EventArgs e)
        {
            if (ad.Text == "Ad")
            {
                ad.Text = "";
                ad.ForeColor = Color.Black;

            }
        }

        private void ad_Leave(object sender, EventArgs e)
        {
            if (ad.Text == "")
            {
                ad.Text = "Ad";
                ad.ForeColor = Color.Silver;

            }
        }

        private void soyad_Enter(object sender, EventArgs e)
        {
            if (soyad.Text == "Soyad")
            {
                soyad.Text = "";
                soyad.ForeColor = Color.Black;

            }
        }

        private void soyad_Leave(object sender, EventArgs e)
        {
            if (soyad.Text == "")
            {
                soyad.Text = "Soyad";
                soyad.ForeColor = Color.Silver;
            }
        }

        private void kullanici_adi_Enter(object sender, EventArgs e)
        {
            if (kullanici_adi.Text == "Kullanıcı-Adı")
            {
                kullanici_adi.Text = "";
                kullanici_adi.ForeColor = Color.Black;
            }
        }

        private void kullanici_adi_Leave(object sender, EventArgs e)
        {
            if (kullanici_adi.Text == "")
            {
                kullanici_adi.Text = "Kullanıcı-Adı";
                kullanici_adi.ForeColor = Color.Silver;
            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "Parola")
            {
                sifre.Text = "";
                sifre.PasswordChar = '*';
                sifre.ForeColor = Color.Black;
            }
        }
        char? passwordkayit = null;
        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Parola";
                sifre.PasswordChar = Convert.ToChar(passwordkayit);
                sifre.ForeColor = Color.Silver;
            }
        }

        private void tc_Enter(object sender, EventArgs e)
        {
            if (tc.Text == "TC")
            {
                tc.Text = "";
                tc.ForeColor = Color.Black;
            }
        }

        private void tc_Leave(object sender, EventArgs e)
        {
            if (tc.Text == "")
            {
                tc.Text = "TC";
                tc.ForeColor = Color.Silver;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "E-mail")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "E-mail";
                email.ForeColor = Color.Silver;
            }
        }

        private void adres_Enter(object sender, EventArgs e)
        {
            if (adres.Text == "Adres")
            {
                adres.Text = "";
                adres.ForeColor = Color.Black;
            }
        }

        private void adres_Leave(object sender, EventArgs e)
        {
            if (adres.Text == "")
            {
                adres.Text = "Adres";
                adres.ForeColor = Color.Silver;
            }
        }

        private void telefon_Enter(object sender, EventArgs e)
        {
            if (telefon.Text == "Telefon")
            {
                telefon.Text = "";
                telefon.ForeColor = Color.Black;
            }
        }

        private void telefon_Leave(object sender, EventArgs e)
        {
            if (telefon.Text == "")
            {
                telefon.Text = "Telefon";
                telefon.ForeColor = Color.Silver;
            }
        }

        private void gerikayit_Click(object sender, EventArgs e)
        {
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();
        }

        
        char? passwordtekrarkayit = null;
        private void sifretekrar_Leave(object sender, EventArgs e)
        {
            if (sifretekrar.Text == "")
            {
                sifretekrar.Text = "Parola-Tekrar";
                sifretekrar.PasswordChar = Convert.ToChar(passwordtekrarkayit);
                sifretekrar.ForeColor = Color.Silver;
            }

        }

        private void sifretekrar_Enter(object sender, EventArgs e)
        {
            if (sifretekrar.Text == "Parola-Tekrar")
            {
                sifretekrar.Text = "";
                sifretekrar.PasswordChar = '*';
                sifretekrar.ForeColor = Color.Black;
            }

        }
        //tasarım için fare tıklaması öncesi ve sonrası için kodlar bitiş


    }
}
