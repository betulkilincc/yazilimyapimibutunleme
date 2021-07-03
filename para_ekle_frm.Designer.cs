namespace Proje_Ödevi
{
    partial class para_ekle_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(para_ekle_frm));
            this.istek_para_lbl = new System.Windows.Forms.Label();
            this.istek_para = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.cikisparaekle = new System.Windows.Forms.Button();
            this.paratip = new System.Windows.Forms.ComboBox();
            this.istekparatip_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // istek_para_lbl
            // 
            this.istek_para_lbl.AutoSize = true;
            this.istek_para_lbl.BackColor = System.Drawing.Color.Transparent;
            this.istek_para_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.istek_para_lbl.Location = new System.Drawing.Point(163, 249);
            this.istek_para_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.istek_para_lbl.Name = "istek_para_lbl";
            this.istek_para_lbl.Size = new System.Drawing.Size(248, 66);
            this.istek_para_lbl.TabIndex = 2;
            this.istek_para_lbl.Text = "Ne kadar eklemek\r\n    istiyorsunuz?";
            // 
            // istek_para
            // 
            this.istek_para.ForeColor = System.Drawing.Color.Silver;
            this.istek_para.HideSelection = false;
            this.istek_para.Location = new System.Drawing.Point(169, 347);
            this.istek_para.Margin = new System.Windows.Forms.Padding(4);
            this.istek_para.Name = "istek_para";
            this.istek_para.Size = new System.Drawing.Size(221, 22);
            this.istek_para.TabIndex = 3;
            this.istek_para.Text = "Lütfen Miktarı giriniz";
            this.istek_para.Enter += new System.EventHandler(this.istek_para_Enter);
            this.istek_para.Leave += new System.EventHandler(this.istek_para_Leave);
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ekle_btn.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ekle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekle_btn.Location = new System.Drawing.Point(194, 390);
            this.ekle_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(156, 46);
            this.ekle_btn.TabIndex = 4;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // cikisparaekle
            // 
            this.cikisparaekle.BackColor = System.Drawing.Color.Transparent;
            this.cikisparaekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisparaekle.FlatAppearance.BorderSize = 0;
            this.cikisparaekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisparaekle.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisparaekle.ForeColor = System.Drawing.Color.Fuchsia;
            this.cikisparaekle.Location = new System.Drawing.Point(560, -2);
            this.cikisparaekle.Margin = new System.Windows.Forms.Padding(4);
            this.cikisparaekle.Name = "cikisparaekle";
            this.cikisparaekle.Size = new System.Drawing.Size(43, 44);
            this.cikisparaekle.TabIndex = 7;
            this.cikisparaekle.Text = "X";
            this.cikisparaekle.UseVisualStyleBackColor = false;
            this.cikisparaekle.Click += new System.EventHandler(this.cikisparaekle_Click);
            // 
            // paratip
            // 
            this.paratip.ForeColor = System.Drawing.Color.Silver;
            this.paratip.FormattingEnabled = true;
            this.paratip.Items.AddRange(new object[] {
            "TRY",
            "EUR",
            "USD",
            "GBP"});
            this.paratip.Location = new System.Drawing.Point(169, 187);
            this.paratip.Margin = new System.Windows.Forms.Padding(4);
            this.paratip.Name = "paratip";
            this.paratip.Size = new System.Drawing.Size(221, 24);
            this.paratip.TabIndex = 8;
            this.paratip.Text = "Para Tipini Seçiniz";
            this.paratip.Enter += new System.EventHandler(this.paratip_Enter);
            this.paratip.Leave += new System.EventHandler(this.paratip_Leave);
            // 
            // istekparatip_lbl
            // 
            this.istekparatip_lbl.AutoSize = true;
            this.istekparatip_lbl.BackColor = System.Drawing.Color.Transparent;
            this.istekparatip_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.istekparatip_lbl.Location = new System.Drawing.Point(163, 102);
            this.istekparatip_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.istekparatip_lbl.Name = "istekparatip_lbl";
            this.istekparatip_lbl.Size = new System.Drawing.Size(268, 66);
            this.istekparatip_lbl.TabIndex = 9;
            this.istekparatip_lbl.Text = "Eklemek istediğiniz \r\nparanın tipini seçiniz";
            // 
            // para_ekle_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 554);
            this.Controls.Add(this.istekparatip_lbl);
            this.Controls.Add(this.paratip);
            this.Controls.Add(this.cikisparaekle);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.istek_para);
            this.Controls.Add(this.istek_para_lbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "para_ekle_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label istek_para_lbl;
        private System.Windows.Forms.TextBox istek_para;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button cikisparaekle;
        private System.Windows.Forms.ComboBox paratip;
        private System.Windows.Forms.Label istekparatip_lbl;
    }
}