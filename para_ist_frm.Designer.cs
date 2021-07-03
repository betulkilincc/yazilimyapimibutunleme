namespace Proje_Ödevi
{
    partial class para_ist_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(para_ist_frm));
            this.paraist_label = new System.Windows.Forms.Label();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.istekler = new System.Windows.Forms.ComboBox();
            this.onaylama_btn = new System.Windows.Forms.Button();
            this.onay_btn = new System.Windows.Forms.Button();
            this.paralisteleme = new System.Windows.Forms.DataGridView();
            this.filtre_lbl = new System.Windows.Forms.Label();
            this.cikisanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paralisteleme)).BeginInit();
            this.SuspendLayout();
            // 
            // paraist_label
            // 
            this.paraist_label.AutoSize = true;
            this.paraist_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.paraist_label.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraist_label.Location = new System.Drawing.Point(27, 25);
            this.paraist_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paraist_label.Name = "paraist_label";
            this.paraist_label.Size = new System.Drawing.Size(156, 27);
            this.paraist_label.TabIndex = 0;
            this.paraist_label.Text = "Para Istekleri:";
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cikis_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis_btn.Location = new System.Drawing.Point(821, 400);
            this.cikis_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(156, 46);
            this.cikis_btn.TabIndex = 3;
            this.cikis_btn.Text = "Geri";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // istekler
            // 
            this.istekler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.istekler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.istekler.FormattingEnabled = true;
            this.istekler.Items.AddRange(new object[] {
            "Onaylanan Kullanıclar",
            "Onaylanmayan Kullanıcılar",
            "Onay Bekleyen Kullanıcılar"});
            this.istekler.Location = new System.Drawing.Point(777, 25);
            this.istekler.Margin = new System.Windows.Forms.Padding(4);
            this.istekler.Name = "istekler";
            this.istekler.Size = new System.Drawing.Size(188, 24);
            this.istekler.TabIndex = 4;
            this.istekler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // onaylama_btn
            // 
            this.onaylama_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.onaylama_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onaylama_btn.Location = new System.Drawing.Point(433, 400);
            this.onaylama_btn.Margin = new System.Windows.Forms.Padding(4);
            this.onaylama_btn.Name = "onaylama_btn";
            this.onaylama_btn.Size = new System.Drawing.Size(156, 46);
            this.onaylama_btn.TabIndex = 5;
            this.onaylama_btn.Text = "Onaylama";
            this.onaylama_btn.UseVisualStyleBackColor = false;
            this.onaylama_btn.Click += new System.EventHandler(this.onaylama_btn_Click);
            // 
            // onay_btn
            // 
            this.onay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.onay_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onay_btn.Location = new System.Drawing.Point(24, 400);
            this.onay_btn.Margin = new System.Windows.Forms.Padding(4);
            this.onay_btn.Name = "onay_btn";
            this.onay_btn.Size = new System.Drawing.Size(156, 46);
            this.onay_btn.TabIndex = 6;
            this.onay_btn.Text = "Onayla";
            this.onay_btn.UseVisualStyleBackColor = false;
            this.onay_btn.Click += new System.EventHandler(this.onay_btn_Click);
            // 
            // paralisteleme
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.paralisteleme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.paralisteleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paralisteleme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paralisteleme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.paralisteleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paralisteleme.DefaultCellStyle = dataGridViewCellStyle3;
            this.paralisteleme.GridColor = System.Drawing.Color.Black;
            this.paralisteleme.Location = new System.Drawing.Point(24, 81);
            this.paralisteleme.Margin = new System.Windows.Forms.Padding(4);
            this.paralisteleme.Name = "paralisteleme";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paralisteleme.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.paralisteleme.RowHeadersVisible = false;
            this.paralisteleme.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.paralisteleme.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.paralisteleme.Size = new System.Drawing.Size(953, 278);
            this.paralisteleme.TabIndex = 7;
            // 
            // filtre_lbl
            // 
            this.filtre_lbl.AutoSize = true;
            this.filtre_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filtre_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtre_lbl.Location = new System.Drawing.Point(700, 23);
            this.filtre_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtre_lbl.Name = "filtre_lbl";
            this.filtre_lbl.Size = new System.Drawing.Size(68, 26);
            this.filtre_lbl.TabIndex = 8;
            this.filtre_lbl.Text = "Filtre:";
            // 
            // cikisanasayfa
            // 
            this.cikisanasayfa.BackColor = System.Drawing.Color.Transparent;
            this.cikisanasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisanasayfa.FlatAppearance.BorderSize = 0;
            this.cikisanasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisanasayfa.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisanasayfa.ForeColor = System.Drawing.Color.Black;
            this.cikisanasayfa.Location = new System.Drawing.Point(973, -6);
            this.cikisanasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.cikisanasayfa.Name = "cikisanasayfa";
            this.cikisanasayfa.Size = new System.Drawing.Size(43, 44);
            this.cikisanasayfa.TabIndex = 9;
            this.cikisanasayfa.Text = "X";
            this.cikisanasayfa.UseVisualStyleBackColor = false;
            this.cikisanasayfa.Click += new System.EventHandler(this.cikisanasayfa_Click);
            // 
            // para_ist_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 495);
            this.Controls.Add(this.cikisanasayfa);
            this.Controls.Add(this.filtre_lbl);
            this.Controls.Add(this.paralisteleme);
            this.Controls.Add(this.onay_btn);
            this.Controls.Add(this.onaylama_btn);
            this.Controls.Add(this.istekler);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.paraist_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "para_ist_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para İstekleri";
            this.Load += new System.EventHandler(this.admin_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paralisteleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paraist_label;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.ComboBox istekler;
        private System.Windows.Forms.Button onaylama_btn;
        private System.Windows.Forms.Button onay_btn;
        private System.Windows.Forms.DataGridView paralisteleme;
        private System.Windows.Forms.Label filtre_lbl;
        private System.Windows.Forms.Button cikisanasayfa;
    }
}