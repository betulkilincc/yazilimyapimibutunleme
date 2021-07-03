namespace Proje_Ödevi
{
    partial class alim_satim_grafik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alim_satim_grafik));
            this.label1 = new System.Windows.Forms.Label();
            this.baslangic_tarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bitis_tarih = new System.Windows.Forms.DateTimePicker();
            this.alimyuzde_txt = new System.Windows.Forms.TextBox();
            this.alim_lbl = new System.Windows.Forms.Label();
            this.satim_lbl = new System.Windows.Forms.Label();
            this.satimyuzde_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALIM-SATIM GRAFİĞİ";
            // 
            // baslangic_tarih
            // 
            this.baslangic_tarih.CalendarFont = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslangic_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baslangic_tarih.Location = new System.Drawing.Point(136, 57);
            this.baslangic_tarih.Margin = new System.Windows.Forms.Padding(4);
            this.baslangic_tarih.Name = "baslangic_tarih";
            this.baslangic_tarih.Size = new System.Drawing.Size(145, 22);
            this.baslangic_tarih.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Grafiği Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bitiş Tarihi:";
            // 
            // bitis_tarih
            // 
            this.bitis_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bitis_tarih.Location = new System.Drawing.Point(136, 110);
            this.bitis_tarih.Margin = new System.Windows.Forms.Padding(4);
            this.bitis_tarih.Name = "bitis_tarih";
            this.bitis_tarih.Size = new System.Drawing.Size(145, 22);
            this.bitis_tarih.TabIndex = 5;
            // 
            // alimyuzde_txt
            // 
            this.alimyuzde_txt.BackColor = System.Drawing.Color.Green;
            this.alimyuzde_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alimyuzde_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alimyuzde_txt.ForeColor = System.Drawing.Color.White;
            this.alimyuzde_txt.Location = new System.Drawing.Point(805, 194);
            this.alimyuzde_txt.Margin = new System.Windows.Forms.Padding(4);
            this.alimyuzde_txt.Multiline = true;
            this.alimyuzde_txt.Name = "alimyuzde_txt";
            this.alimyuzde_txt.Size = new System.Drawing.Size(67, 37);
            this.alimyuzde_txt.TabIndex = 6;
            // 
            // alim_lbl
            // 
            this.alim_lbl.AutoSize = true;
            this.alim_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alim_lbl.Location = new System.Drawing.Point(877, 197);
            this.alim_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alim_lbl.Name = "alim_lbl";
            this.alim_lbl.Size = new System.Drawing.Size(60, 29);
            this.alim_lbl.TabIndex = 7;
            this.alim_lbl.Text = "Alım";
            // 
            // satim_lbl
            // 
            this.satim_lbl.AutoSize = true;
            this.satim_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satim_lbl.Location = new System.Drawing.Point(877, 247);
            this.satim_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.satim_lbl.Name = "satim_lbl";
            this.satim_lbl.Size = new System.Drawing.Size(74, 29);
            this.satim_lbl.TabIndex = 9;
            this.satim_lbl.Text = "Satım";
            // 
            // satimyuzde_txt
            // 
            this.satimyuzde_txt.BackColor = System.Drawing.Color.Red;
            this.satimyuzde_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.satimyuzde_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satimyuzde_txt.ForeColor = System.Drawing.Color.White;
            this.satimyuzde_txt.Location = new System.Drawing.Point(805, 245);
            this.satimyuzde_txt.Margin = new System.Windows.Forms.Padding(4);
            this.satimyuzde_txt.Multiline = true;
            this.satimyuzde_txt.Name = "satimyuzde_txt";
            this.satimyuzde_txt.Size = new System.Drawing.Size(67, 37);
            this.satimyuzde_txt.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 245);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Gerİdön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alim_satim_grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.satimyuzde_txt);
            this.Controls.Add(this.satim_lbl);
            this.Controls.Add(this.alim_lbl);
            this.Controls.Add(this.alimyuzde_txt);
            this.Controls.Add(this.bitis_tarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.baslangic_tarih);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "alim_satim_grafik";
            this.Text = "alim_satim_grafik";
            this.Load += new System.EventHandler(this.alim_satim_grafik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker baslangic_tarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker bitis_tarih;
        private System.Windows.Forms.TextBox alimyuzde_txt;
        private System.Windows.Forms.Label alim_lbl;
        private System.Windows.Forms.Label satim_lbl;
        private System.Windows.Forms.TextBox satimyuzde_txt;
        private System.Windows.Forms.Button button2;
    }
}