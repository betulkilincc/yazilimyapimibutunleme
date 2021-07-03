namespace Proje_Ödevi
{
    partial class kayit_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit_frm));
            this.kayit_btn = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.cikiskayit = new System.Windows.Forms.Button();
            this.gerikayit = new System.Windows.Forms.Button();
            this.uyeol_lbl = new System.Windows.Forms.Label();
            this.sifretekrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kayit_btn
            // 
            this.kayit_btn.BackColor = System.Drawing.Color.Teal;
            this.kayit_btn.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.kayit_btn.Location = new System.Drawing.Point(45, 571);
            this.kayit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(200, 48);
            this.kayit_btn.TabIndex = 8;
            this.kayit_btn.Text = "Kayıt Ol";
            this.kayit_btn.UseVisualStyleBackColor = false;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.Window;
            this.ad.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.Color.Silver;
            this.ad.Location = new System.Drawing.Point(45, 175);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(199, 29);
            this.ad.TabIndex = 9;
            this.ad.Text = "Ad";
            this.ad.Enter += new System.EventHandler(this.ad_Enter);
            this.ad.Leave += new System.EventHandler(this.ad_Leave);
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyad.ForeColor = System.Drawing.Color.Silver;
            this.soyad.Location = new System.Drawing.Point(45, 215);
            this.soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(199, 29);
            this.soyad.TabIndex = 10;
            this.soyad.Text = "Soyad";
            this.soyad.Enter += new System.EventHandler(this.soyad_Enter);
            this.soyad.Leave += new System.EventHandler(this.soyad_Leave);
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_adi.ForeColor = System.Drawing.Color.Silver;
            this.kullanici_adi.Location = new System.Drawing.Point(45, 256);
            this.kullanici_adi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(199, 29);
            this.kullanici_adi.TabIndex = 11;
            this.kullanici_adi.Text = "Kullanıcı-Adı";
            this.kullanici_adi.Enter += new System.EventHandler(this.kullanici_adi_Enter);
            this.kullanici_adi.Leave += new System.EventHandler(this.kullanici_adi_Leave);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Silver;
            this.email.Location = new System.Drawing.Point(528, 254);
            this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(199, 29);
            this.email.TabIndex = 13;
            this.email.Text = "E-mail";
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.ForeColor = System.Drawing.Color.Silver;
            this.telefon.Location = new System.Drawing.Point(528, 426);
            this.telefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefon.MaxLength = 11;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(199, 29);
            this.telefon.TabIndex = 14;
            this.telefon.Text = "Telefon";
            this.telefon.Enter += new System.EventHandler(this.telefon_Enter);
            this.telefon.Leave += new System.EventHandler(this.telefon_Leave);
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.ForeColor = System.Drawing.Color.Silver;
            this.sifre.Location = new System.Drawing.Point(45, 369);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(199, 29);
            this.sifre.TabIndex = 15;
            this.sifre.Text = "Parola";
            this.sifre.Enter += new System.EventHandler(this.sifre_Enter);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // tc
            // 
            this.tc.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc.ForeColor = System.Drawing.Color.Silver;
            this.tc.Location = new System.Drawing.Point(528, 197);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tc.MaxLength = 11;
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(199, 29);
            this.tc.TabIndex = 16;
            this.tc.Text = "TC";
            this.tc.Enter += new System.EventHandler(this.tc_Enter);
            this.tc.Leave += new System.EventHandler(this.tc_Leave);
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adres.ForeColor = System.Drawing.Color.Silver;
            this.adres.Location = new System.Drawing.Point(528, 369);
            this.adres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(199, 29);
            this.adres.TabIndex = 17;
            this.adres.Text = "Adres";
            this.adres.Enter += new System.EventHandler(this.adres_Enter);
            this.adres.Leave += new System.EventHandler(this.adres_Leave);
            // 
            // cikiskayit
            // 
            this.cikiskayit.BackColor = System.Drawing.Color.Transparent;
            this.cikiskayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikiskayit.FlatAppearance.BorderSize = 0;
            this.cikiskayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikiskayit.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikiskayit.ForeColor = System.Drawing.Color.Black;
            this.cikiskayit.Location = new System.Drawing.Point(728, -5);
            this.cikiskayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikiskayit.Name = "cikiskayit";
            this.cikiskayit.Size = new System.Drawing.Size(43, 44);
            this.cikiskayit.TabIndex = 18;
            this.cikiskayit.Text = "X";
            this.cikiskayit.UseVisualStyleBackColor = false;
            this.cikiskayit.Click += new System.EventHandler(this.cikiskayit_Click);
            // 
            // gerikayit
            // 
            this.gerikayit.BackColor = System.Drawing.Color.Teal;
            this.gerikayit.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerikayit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gerikayit.Location = new System.Drawing.Point(528, 571);
            this.gerikayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gerikayit.Name = "gerikayit";
            this.gerikayit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gerikayit.Size = new System.Drawing.Size(200, 48);
            this.gerikayit.TabIndex = 19;
            this.gerikayit.Text = "Geri";
            this.gerikayit.UseVisualStyleBackColor = false;
            this.gerikayit.Click += new System.EventHandler(this.gerikayit_Click);
            // 
            // uyeol_lbl
            // 
            this.uyeol_lbl.AutoSize = true;
            this.uyeol_lbl.BackColor = System.Drawing.Color.Transparent;
            this.uyeol_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeol_lbl.ForeColor = System.Drawing.Color.Black;
            this.uyeol_lbl.Location = new System.Drawing.Point(305, 61);
            this.uyeol_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uyeol_lbl.Name = "uyeol_lbl";
            this.uyeol_lbl.Size = new System.Drawing.Size(159, 54);
            this.uyeol_lbl.TabIndex = 20;
            this.uyeol_lbl.Text = "Üye Ol";
            // 
            // sifretekrar
            // 
            this.sifretekrar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifretekrar.ForeColor = System.Drawing.Color.Silver;
            this.sifretekrar.Location = new System.Drawing.Point(45, 426);
            this.sifretekrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifretekrar.Name = "sifretekrar";
            this.sifretekrar.Size = new System.Drawing.Size(199, 29);
            this.sifretekrar.TabIndex = 22;
            this.sifretekrar.Text = "Parola-Tekrar";
            this.sifretekrar.Enter += new System.EventHandler(this.sifretekrar_Enter);
            this.sifretekrar.Leave += new System.EventHandler(this.sifretekrar_Leave);
            // 
            // kayit_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 708);
            this.Controls.Add(this.sifretekrar);
            this.Controls.Add(this.uyeol_lbl);
            this.Controls.Add(this.gerikayit);
            this.Controls.Add(this.cikiskayit);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.kayit_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kayit_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Button cikiskayit;
        private System.Windows.Forms.Button gerikayit;
        private System.Windows.Forms.Label uyeol_lbl;
        private System.Windows.Forms.TextBox sifretekrar;
    }
}