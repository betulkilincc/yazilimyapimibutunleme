namespace Proje_Ödevi
{
    partial class Giris_frm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button logo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_frm));
            this.kullacini_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.gris_btn = new System.Windows.Forms.Button();
            this.kayit_btn = new System.Windows.Forms.Button();
            this.cikisgiris = new System.Windows.Forms.Button();
            logo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = System.Drawing.Color.Transparent;
            logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            logo.Enabled = false;
            logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(209)))));
            logo.Location = new System.Drawing.Point(255, 153);
            logo.Margin = new System.Windows.Forms.Padding(4);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(257, 261);
            logo.TabIndex = 8;
            logo.UseVisualStyleBackColor = false;
            // 
            // kullacini_txt
            // 
            this.kullacini_txt.BackColor = System.Drawing.SystemColors.Window;
            this.kullacini_txt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullacini_txt.ForeColor = System.Drawing.Color.Silver;
            this.kullacini_txt.Location = new System.Drawing.Point(265, 421);
            this.kullacini_txt.Margin = new System.Windows.Forms.Padding(4);
            this.kullacini_txt.Name = "kullacini_txt";
            this.kullacini_txt.Size = new System.Drawing.Size(231, 29);
            this.kullacini_txt.TabIndex = 2;
            this.kullacini_txt.Text = "Kullanici-Adi";
            this.kullacini_txt.Enter += new System.EventHandler(this.kullacini_txt_Enter);
            this.kullacini_txt.Leave += new System.EventHandler(this.kullacini_txt_Leave);
            // 
            // sifre_txt
            // 
            this.sifre_txt.BackColor = System.Drawing.SystemColors.Window;
            this.sifre_txt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_txt.ForeColor = System.Drawing.Color.Silver;
            this.sifre_txt.Location = new System.Drawing.Point(265, 473);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(4);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(231, 29);
            this.sifre_txt.TabIndex = 3;
            this.sifre_txt.Text = "Parola";
            this.sifre_txt.Enter += new System.EventHandler(this.sifre_txt_Enter);
            this.sifre_txt.Leave += new System.EventHandler(this.sifre_txt_Leave);
            // 
            // gris_btn
            // 
            this.gris_btn.BackColor = System.Drawing.Color.Aqua;
            this.gris_btn.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gris_btn.ForeColor = System.Drawing.Color.Black;
            this.gris_btn.Location = new System.Drawing.Point(265, 513);
            this.gris_btn.Margin = new System.Windows.Forms.Padding(4);
            this.gris_btn.Name = "gris_btn";
            this.gris_btn.Size = new System.Drawing.Size(109, 42);
            this.gris_btn.TabIndex = 4;
            this.gris_btn.Text = "Giris";
            this.gris_btn.UseVisualStyleBackColor = false;
            this.gris_btn.Click += new System.EventHandler(this.gris_btn_Click);
            // 
            // kayit_btn
            // 
            this.kayit_btn.BackColor = System.Drawing.Color.Aqua;
            this.kayit_btn.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_btn.ForeColor = System.Drawing.Color.Black;
            this.kayit_btn.Location = new System.Drawing.Point(383, 513);
            this.kayit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(115, 42);
            this.kayit_btn.TabIndex = 5;
            this.kayit_btn.Text = "Kayit";
            this.kayit_btn.UseVisualStyleBackColor = false;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // cikisgiris
            // 
            this.cikisgiris.BackColor = System.Drawing.Color.Transparent;
            this.cikisgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisgiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisgiris.FlatAppearance.BorderSize = 0;
            this.cikisgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisgiris.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisgiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cikisgiris.Location = new System.Drawing.Point(732, -2);
            this.cikisgiris.Margin = new System.Windows.Forms.Padding(4);
            this.cikisgiris.Name = "cikisgiris";
            this.cikisgiris.Size = new System.Drawing.Size(36, 44);
            this.cikisgiris.TabIndex = 6;
            this.cikisgiris.Text = "X";
            this.cikisgiris.UseVisualStyleBackColor = false;
            this.cikisgiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // Giris_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 708);
            this.Controls.Add(logo);
            this.Controls.Add(this.cikisgiris);
            this.Controls.Add(this.kayit_btn);
            this.Controls.Add(this.gris_btn);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.kullacini_txt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox kullacini_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Button gris_btn;
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.Button cikisgiris;
    }
}

