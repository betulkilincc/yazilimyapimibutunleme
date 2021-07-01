namespace Proje_Ödevi
{
    partial class admin_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_frm));
            this.para_list_btn = new System.Windows.Forms.Button();
            this.satis_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.cikisadmin = new System.Windows.Forms.Button();
            this.tumkullanicilar = new System.Windows.Forms.DataGridView();
            this.adminpnl = new System.Windows.Forms.Label();
            this.kullanici_sayisi = new System.Windows.Forms.Label();
            this.tkullanicisay = new System.Windows.Forms.Label();
            this.sohbet_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tumkullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // para_list_btn
            // 
            this.para_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.para_list_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_list_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.para_list_btn.Location = new System.Drawing.Point(36, 405);
            this.para_list_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.para_list_btn.Name = "para_list_btn";
            this.para_list_btn.Size = new System.Drawing.Size(162, 46);
            this.para_list_btn.TabIndex = 0;
            this.para_list_btn.Text = "Para İstekleri";
            this.para_list_btn.UseVisualStyleBackColor = false;
            this.para_list_btn.Click += new System.EventHandler(this.para_list_btn_Click);
            // 
            // satis_btn
            // 
            this.satis_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.satis_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satis_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.satis_btn.Location = new System.Drawing.Point(206, 405);
            this.satis_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satis_btn.Name = "satis_btn";
            this.satis_btn.Size = new System.Drawing.Size(176, 46);
            this.satis_btn.TabIndex = 1;
            this.satis_btn.Text = "Satış İstekleri";
            this.satis_btn.UseVisualStyleBackColor = false;
            this.satis_btn.Click += new System.EventHandler(this.satis_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cikis_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cikis_btn.Location = new System.Drawing.Point(805, 405);
            this.cikis_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(156, 46);
            this.cikis_btn.TabIndex = 2;
            this.cikis_btn.Text = "Çıkış";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // cikisadmin
            // 
            this.cikisadmin.BackColor = System.Drawing.Color.Transparent;
            this.cikisadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisadmin.FlatAppearance.BorderSize = 0;
            this.cikisadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisadmin.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cikisadmin.Location = new System.Drawing.Point(973, -6);
            this.cikisadmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikisadmin.Name = "cikisadmin";
            this.cikisadmin.Size = new System.Drawing.Size(43, 44);
            this.cikisadmin.TabIndex = 11;
            this.cikisadmin.Text = "X";
            this.cikisadmin.UseVisualStyleBackColor = false;
            this.cikisadmin.Click += new System.EventHandler(this.cikisadmin_Click);
            // 
            // tumkullanicilar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tumkullanicilar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tumkullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tumkullanicilar.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tumkullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tumkullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tumkullanicilar.DefaultCellStyle = dataGridViewCellStyle3;
            this.tumkullanicilar.GridColor = System.Drawing.Color.Black;
            this.tumkullanicilar.Location = new System.Drawing.Point(20, 95);
            this.tumkullanicilar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tumkullanicilar.Name = "tumkullanicilar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tumkullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tumkullanicilar.RowHeadersVisible = false;
            this.tumkullanicilar.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tumkullanicilar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tumkullanicilar.Size = new System.Drawing.Size(953, 278);
            this.tumkullanicilar.TabIndex = 17;
            // 
            // adminpnl
            // 
            this.adminpnl.AutoSize = true;
            this.adminpnl.BackColor = System.Drawing.Color.Transparent;
            this.adminpnl.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpnl.ForeColor = System.Drawing.Color.Black;
            this.adminpnl.Location = new System.Drawing.Point(369, 20);
            this.adminpnl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminpnl.Name = "adminpnl";
            this.adminpnl.Size = new System.Drawing.Size(268, 49);
            this.adminpnl.TabIndex = 18;
            this.adminpnl.Text = "Admin Paneli";
            // 
            // kullanici_sayisi
            // 
            this.kullanici_sayisi.AutoSize = true;
            this.kullanici_sayisi.BackColor = System.Drawing.Color.Transparent;
            this.kullanici_sayisi.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_sayisi.ForeColor = System.Drawing.Color.Black;
            this.kullanici_sayisi.Location = new System.Drawing.Point(167, 39);
            this.kullanici_sayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullanici_sayisi.Name = "kullanici_sayisi";
            this.kullanici_sayisi.Size = new System.Drawing.Size(154, 30);
            this.kullanici_sayisi.TabIndex = 19;
            this.kullanici_sayisi.Text = "Kullanicisayi";
            // 
            // tkullanicisay
            // 
            this.tkullanicisay.AutoSize = true;
            this.tkullanicisay.BackColor = System.Drawing.Color.Transparent;
            this.tkullanicisay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tkullanicisay.ForeColor = System.Drawing.Color.Black;
            this.tkullanicisay.Location = new System.Drawing.Point(17, 42);
            this.tkullanicisay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tkullanicisay.Name = "tkullanicisay";
            this.tkullanicisay.Size = new System.Drawing.Size(146, 34);
            this.tkullanicisay.TabIndex = 20;
            this.tkullanicisay.Text = "Toplam Kullanıcı  \r\n       Sayısı            ";
            // 
            // sohbet_btn
            // 
            this.sohbet_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sohbet_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sohbet_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sohbet_btn.Location = new System.Drawing.Point(390, 405);
            this.sohbet_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sohbet_btn.Name = "sohbet_btn";
            this.sohbet_btn.Size = new System.Drawing.Size(118, 46);
            this.sohbet_btn.TabIndex = 21;
            this.sohbet_btn.Text = "Sohbet";
            this.sohbet_btn.UseVisualStyleBackColor = false;
            this.sohbet_btn.Click += new System.EventHandler(this.sohbet_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(516, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Alım-Satım Grafigi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sohbet_btn);
            this.Controls.Add(this.tkullanicisay);
            this.Controls.Add(this.kullanici_sayisi);
            this.Controls.Add(this.adminpnl);
            this.Controls.Add(this.tumkullanicilar);
            this.Controls.Add(this.cikisadmin);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.satis_btn);
            this.Controls.Add(this.para_list_btn);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admin_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.admin_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tumkullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button para_list_btn;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button cikisadmin;
        private System.Windows.Forms.DataGridView tumkullanicilar;
        private System.Windows.Forms.Label adminpnl;
        private System.Windows.Forms.Label kullanici_sayisi;
        private System.Windows.Forms.Label tkullanicisay;
        private System.Windows.Forms.Button sohbet_btn;
        private System.Windows.Forms.Button button1;
    }
}