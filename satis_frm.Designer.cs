namespace Proje_Ödevi
{
    partial class satis_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satis_frm));
            this.birimdeger_lbl = new System.Windows.Forms.Label();
            this.birimdeger = new System.Windows.Forms.TextBox();
            this.onay_btn = new System.Windows.Forms.Button();
            this.birimfiyat = new System.Windows.Forms.TextBox();
            this.birimfiyat_lbl = new System.Windows.Forms.Label();
            this.cikissatisekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birimdeger_lbl
            // 
            this.birimdeger_lbl.AutoSize = true;
            this.birimdeger_lbl.BackColor = System.Drawing.Color.Transparent;
            this.birimdeger_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimdeger_lbl.Location = new System.Drawing.Point(148, 130);
            this.birimdeger_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birimdeger_lbl.Name = "birimdeger_lbl";
            this.birimdeger_lbl.Size = new System.Drawing.Size(273, 21);
            this.birimdeger_lbl.TabIndex = 0;
            this.birimdeger_lbl.Text = "Ne kadar satmak istiyorsunuz?";
            // 
            // birimdeger
            // 
            this.birimdeger.ForeColor = System.Drawing.Color.Silver;
            this.birimdeger.Location = new System.Drawing.Point(152, 169);
            this.birimdeger.Margin = new System.Windows.Forms.Padding(4);
            this.birimdeger.Name = "birimdeger";
            this.birimdeger.Size = new System.Drawing.Size(232, 22);
            this.birimdeger.TabIndex = 1;
            this.birimdeger.Text = "Satmak istediğiniz miktari giriniz";
            this.birimdeger.Enter += new System.EventHandler(this.birimdeger_Enter);
            this.birimdeger.Leave += new System.EventHandler(this.birimdeger_Leave);
            // 
            // onay_btn
            // 
            this.onay_btn.BackColor = System.Drawing.SystemColors.Control;
            this.onay_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.onay_btn.ForeColor = System.Drawing.Color.Black;
            this.onay_btn.Location = new System.Drawing.Point(152, 337);
            this.onay_btn.Margin = new System.Windows.Forms.Padding(4);
            this.onay_btn.Name = "onay_btn";
            this.onay_btn.Size = new System.Drawing.Size(233, 46);
            this.onay_btn.TabIndex = 2;
            this.onay_btn.Text = "Onayla";
            this.onay_btn.UseVisualStyleBackColor = false;
            this.onay_btn.Click += new System.EventHandler(this.onay_btn_Click);
            // 
            // birimfiyat
            // 
            this.birimfiyat.ForeColor = System.Drawing.Color.Silver;
            this.birimfiyat.Location = new System.Drawing.Point(152, 264);
            this.birimfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.birimfiyat.Name = "birimfiyat";
            this.birimfiyat.Size = new System.Drawing.Size(232, 22);
            this.birimfiyat.TabIndex = 4;
            this.birimfiyat.Text = "Satmak istediğiniz birim fiyati giriniz";
            this.birimfiyat.Enter += new System.EventHandler(this.birimfiyat_Enter);
            this.birimfiyat.Leave += new System.EventHandler(this.birimfiyat_Leave);
            // 
            // birimfiyat_lbl
            // 
            this.birimfiyat_lbl.AutoSize = true;
            this.birimfiyat_lbl.BackColor = System.Drawing.Color.Transparent;
            this.birimfiyat_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimfiyat_lbl.Location = new System.Drawing.Point(148, 226);
            this.birimfiyat_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birimfiyat_lbl.Name = "birimfiyat_lbl";
            this.birimfiyat_lbl.Size = new System.Drawing.Size(201, 21);
            this.birimfiyat_lbl.TabIndex = 3;
            this.birimfiyat_lbl.Text = "Birim Fiyat Belirleyiniz";
            // 
            // cikissatisekle
            // 
            this.cikissatisekle.BackColor = System.Drawing.Color.Transparent;
            this.cikissatisekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikissatisekle.FlatAppearance.BorderSize = 0;
            this.cikissatisekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikissatisekle.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikissatisekle.ForeColor = System.Drawing.Color.Brown;
            this.cikissatisekle.Location = new System.Drawing.Point(493, -2);
            this.cikissatisekle.Margin = new System.Windows.Forms.Padding(4);
            this.cikissatisekle.Name = "cikissatisekle";
            this.cikissatisekle.Size = new System.Drawing.Size(43, 44);
            this.cikissatisekle.TabIndex = 8;
            this.cikissatisekle.Text = "X";
            this.cikissatisekle.UseVisualStyleBackColor = false;
            this.cikissatisekle.Click += new System.EventHandler(this.cikisparaekle_Click);
            // 
            // satis_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 492);
            this.Controls.Add(this.cikissatisekle);
            this.Controls.Add(this.birimfiyat);
            this.Controls.Add(this.birimfiyat_lbl);
            this.Controls.Add(this.onay_btn);
            this.Controls.Add(this.birimdeger);
            this.Controls.Add(this.birimdeger_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "satis_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şatış Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label birimdeger_lbl;
        private System.Windows.Forms.TextBox birimdeger;
        private System.Windows.Forms.Button onay_btn;
        private System.Windows.Forms.TextBox birimfiyat;
        private System.Windows.Forms.Label birimfiyat_lbl;
        private System.Windows.Forms.Button cikissatisekle;
    }
}