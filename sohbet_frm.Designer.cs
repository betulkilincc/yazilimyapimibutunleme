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
            this.urunlistele = new System.Windows.Forms.DataGridView();
            this.mesaj_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataView1 = new System.Data.DataView();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.dataSet1 = new System.Data.DataSet();
            this.button2 = new System.Windows.Forms.Button();
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
            this.urunlistele.Location = new System.Drawing.Point(0, 0);
            this.urunlistele.Name = "urunlistele";
            this.urunlistele.ReadOnly = true;
            this.urunlistele.Size = new System.Drawing.Size(800, 303);
            this.urunlistele.TabIndex = 0;
            // 
            // mesaj_txt
            // 
            this.mesaj_txt.Location = new System.Drawing.Point(131, 331);
            this.mesaj_txt.Multiline = true;
            this.mesaj_txt.Name = "mesaj_txt";
            this.mesaj_txt.Size = new System.Drawing.Size(458, 82);
            this.mesaj_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mesaj Yaz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "geri dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kullanici_cmb
            // 
            this.kullanici_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_cmb.FormattingEnabled = true;
            this.kullanici_cmb.Location = new System.Drawing.Point(629, 362);
            this.kullanici_cmb.Name = "kullanici_cmb";
            this.kullanici_cmb.Size = new System.Drawing.Size(146, 24);
            this.kullanici_cmb.TabIndex = 6;
            this.kullanici_cmb.Text = "Kullanıcı Seç";
            // 
            // sohbet_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 486);
            this.Controls.Add(this.kullanici_cmb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mesaj_txt);
            this.Controls.Add(this.urunlistele);
            this.Location = new System.Drawing.Point(150, 50);
            this.Name = "sohbet_frm";
            this.Text = "sohbet_frm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Data.DataView dataView1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox kullanici_cmb;
    }
}