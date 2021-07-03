namespace Proje_Ödevi
{
    partial class satis_ist_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satis_ist_frm));
            this.onay_btn = new System.Windows.Forms.Button();
            this.onaylama_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.filtre_lbl = new System.Windows.Forms.Label();
            this.satislisteleme = new System.Windows.Forms.DataGridView();
            this.filtre = new System.Windows.Forms.ComboBox();
            this.satis_label = new System.Windows.Forms.Label();
            this.cikissatisistek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.satislisteleme)).BeginInit();
            this.SuspendLayout();
            // 
            // onay_btn
            // 
            this.onay_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onay_btn.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onay_btn.Location = new System.Drawing.Point(24, 400);
            this.onay_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onay_btn.Name = "onay_btn";
            this.onay_btn.Size = new System.Drawing.Size(156, 46);
            this.onay_btn.TabIndex = 9;
            this.onay_btn.Text = "Onayla";
            this.onay_btn.UseVisualStyleBackColor = false;
            this.onay_btn.Click += new System.EventHandler(this.onay_btn_Click);
            // 
            // onaylama_btn
            // 
            this.onaylama_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onaylama_btn.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onaylama_btn.Location = new System.Drawing.Point(433, 400);
            this.onaylama_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onaylama_btn.Name = "onaylama_btn";
            this.onaylama_btn.Size = new System.Drawing.Size(156, 46);
            this.onaylama_btn.TabIndex = 8;
            this.onaylama_btn.Text = "Onaylama";
            this.onaylama_btn.UseVisualStyleBackColor = false;
            this.onaylama_btn.Click += new System.EventHandler(this.onaylama_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cikis_btn.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis_btn.Location = new System.Drawing.Point(821, 400);
            this.cikis_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(156, 46);
            this.cikis_btn.TabIndex = 7;
            this.cikis_btn.Text = "Geri";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // filtre_lbl
            // 
            this.filtre_lbl.AutoSize = true;
            this.filtre_lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filtre_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtre_lbl.Location = new System.Drawing.Point(700, 23);
            this.filtre_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtre_lbl.Name = "filtre_lbl";
            this.filtre_lbl.Size = new System.Drawing.Size(68, 26);
            this.filtre_lbl.TabIndex = 13;
            this.filtre_lbl.Text = "Filtre:";
            // 
            // satislisteleme
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.satislisteleme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.satislisteleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.satislisteleme.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.satislisteleme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.satislisteleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.satislisteleme.DefaultCellStyle = dataGridViewCellStyle3;
            this.satislisteleme.GridColor = System.Drawing.Color.Black;
            this.satislisteleme.Location = new System.Drawing.Point(24, 81);
            this.satislisteleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satislisteleme.Name = "satislisteleme";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.satislisteleme.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.satislisteleme.RowHeadersVisible = false;
            this.satislisteleme.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.satislisteleme.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.satislisteleme.Size = new System.Drawing.Size(953, 278);
            this.satislisteleme.TabIndex = 12;
            // 
            // filtre
            // 
            this.filtre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filtre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtre.FormattingEnabled = true;
            this.filtre.Items.AddRange(new object[] {
            "Onaylanan Kullanıclar",
            "Onaylanmayan Kullanıcılar",
            "Onay Bekleyen Kullanıcılar"});
            this.filtre.Location = new System.Drawing.Point(777, 25);
            this.filtre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filtre.Name = "filtre";
            this.filtre.Size = new System.Drawing.Size(188, 24);
            this.filtre.TabIndex = 11;
            this.filtre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // satis_label
            // 
            this.satis_label.AutoSize = true;
            this.satis_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satis_label.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satis_label.Location = new System.Drawing.Point(27, 25);
            this.satis_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.satis_label.Name = "satis_label";
            this.satis_label.Size = new System.Drawing.Size(169, 31);
            this.satis_label.TabIndex = 10;
            this.satis_label.Text = "Satis Istekleri:";
            // 
            // cikissatisistek
            // 
            this.cikissatisistek.BackColor = System.Drawing.Color.Transparent;
            this.cikissatisistek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikissatisistek.FlatAppearance.BorderSize = 0;
            this.cikissatisistek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikissatisistek.Font = new System.Drawing.Font("Futura Md BT", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikissatisistek.ForeColor = System.Drawing.Color.Black;
            this.cikissatisistek.Location = new System.Drawing.Point(973, -6);
            this.cikissatisistek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikissatisistek.Name = "cikissatisistek";
            this.cikissatisistek.Size = new System.Drawing.Size(43, 44);
            this.cikissatisistek.TabIndex = 14;
            this.cikissatisistek.Text = "X";
            this.cikissatisistek.UseVisualStyleBackColor = false;
            this.cikissatisistek.Click += new System.EventHandler(this.cikissatisistek_Click);
            // 
            // satis_ist_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1011, 495);
            this.Controls.Add(this.cikissatisistek);
            this.Controls.Add(this.filtre_lbl);
            this.Controls.Add(this.satislisteleme);
            this.Controls.Add(this.filtre);
            this.Controls.Add(this.satis_label);
            this.Controls.Add(this.onay_btn);
            this.Controls.Add(this.onaylama_btn);
            this.Controls.Add(this.cikis_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "satis_ist_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İstekleri";
            this.Load += new System.EventHandler(this.satis_ist_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satislisteleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onay_btn;
        private System.Windows.Forms.Button onaylama_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Label filtre_lbl;
        private System.Windows.Forms.DataGridView satislisteleme;
        private System.Windows.Forms.ComboBox filtre;
        private System.Windows.Forms.Label satis_label;
        private System.Windows.Forms.Button cikissatisistek;
    }
}