namespace Proje_Ödevi
{
    partial class sohbet_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sohbet_frm));
            this.urunlistele = new System.Windows.Forms.DataGridView();
            this.mesaj_txt = new System.Windows.Forms.TextBox();
            this.mesajYaz_label = new System.Windows.Forms.Label();
            this.gonder_button = new System.Windows.Forms.Button();
            this.dataView1 = new System.Data.DataView();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.dataSet1 = new System.Data.DataSet();
            this.geri_don_btn = new System.Windows.Forms.Button();
            this.kullanici_cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.urunlistele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // urunlistele
            // 
            this.urunlistele.AllowUserToAddRows = false;
            this.urunlistele.AllowUserToDeleteRows = false;
            this.urunlistele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlistele.Location = new System.Drawing.Point(61, 62);
            this.urunlistele.Margin = new System.Windows.Forms.Padding(4);
            this.urunlistele.Name = "urunlistele";
            this.urunlistele.ReadOnly = true;
            this.urunlistele.RowHeadersWidth = 51;
            this.urunlistele.Size = new System.Drawing.Size(957, 342);
            this.urunlistele.TabIndex = 0;
            // 
            // mesaj_txt
            // 
            this.mesaj_txt.Location = new System.Drawing.Point(175, 446);
            this.mesaj_txt.Margin = new System.Windows.Forms.Padding(4);
            this.mesaj_txt.Multiline = true;
            this.mesaj_txt.Name = "mesaj_txt";
            this.mesaj_txt.Size = new System.Drawing.Size(594, 38);
            this.mesaj_txt.TabIndex = 1;
            // 
            // mesajYaz_label
            // 
            this.mesajYaz_label.AutoSize = true;
            this.mesajYaz_label.BackColor = System.Drawing.Color.Transparent;
            this.mesajYaz_label.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesajYaz_label.Location = new System.Drawing.Point(26, 449);
            this.mesajYaz_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mesajYaz_label.Name = "mesajYaz_label";
            this.mesajYaz_label.Size = new System.Drawing.Size(132, 31);
            this.mesajYaz_label.TabIndex = 2;
            this.mesajYaz_label.Text = "Mesaj Yaz";
            // 
            // gonder_button
            // 
            this.gonder_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gonder_button.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gonder_button.Location = new System.Drawing.Point(602, 500);
            this.gonder_button.Margin = new System.Windows.Forms.Padding(4);
            this.gonder_button.Name = "gonder_button";
            this.gonder_button.Size = new System.Drawing.Size(112, 41);
            this.gonder_button.TabIndex = 3;
            this.gonder_button.Text = "Gonder";
            this.gonder_button.UseVisualStyleBackColor = false;
            this.gonder_button.Click += new System.EventHandler(this.gonder_Click);
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // geri_don_btn
            // 
            this.geri_don_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.geri_don_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri_don_btn.Location = new System.Drawing.Point(379, 500);
            this.geri_don_btn.Margin = new System.Windows.Forms.Padding(4);
            this.geri_don_btn.Name = "geri_don_btn";
            this.geri_don_btn.Size = new System.Drawing.Size(126, 41);
            this.geri_don_btn.TabIndex = 4;
            this.geri_don_btn.Text = "Geri don";
            this.geri_don_btn.UseVisualStyleBackColor = false;
            this.geri_don_btn.Click += new System.EventHandler(this.geri_don_Click);
            // 
            // kullanici_cmb
            // 
            this.kullanici_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kullanici_cmb.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_cmb.FormattingEnabled = true;
            this.kullanici_cmb.Location = new System.Drawing.Point(795, 446);
            this.kullanici_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.kullanici_cmb.Name = "kullanici_cmb";
            this.kullanici_cmb.Size = new System.Drawing.Size(193, 38);
            this.kullanici_cmb.TabIndex = 6;
            this.kullanici_cmb.Text = "Kullanici Sec";
            // 
            // sohbet_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 598);
            this.Controls.Add(this.kullanici_cmb);
            this.Controls.Add(this.geri_don_btn);
            this.Controls.Add(this.gonder_button);
            this.Controls.Add(this.mesajYaz_label);
            this.Controls.Add(this.mesaj_txt);
            this.Controls.Add(this.urunlistele);
            this.Location = new System.Drawing.Point(150, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sohbet_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sohbet";
            this.Load += new System.EventHandler(this.sohbet_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlistele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView urunlistele;
        private System.Windows.Forms.TextBox mesaj_txt;
        private System.Windows.Forms.Label mesajYaz_label;
        private System.Windows.Forms.Button gonder_button;
        private System.Data.DataView dataView1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button geri_don_btn;
        private System.Windows.Forms.ComboBox kullanici_cmb;
    }
}