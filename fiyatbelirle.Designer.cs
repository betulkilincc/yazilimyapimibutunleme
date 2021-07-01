namespace Proje_Ödevi
{
    partial class fiyatbelirle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fiyatbelirle));
            this.fiyatb_txt = new System.Windows.Forms.TextBox();
            this.fiyatbelirle_btn = new System.Windows.Forms.Button();
            this.cikisfiyatbelirle = new System.Windows.Forms.Button();
            this.fiyatb_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fiyatb_txt
            // 
            this.fiyatb_txt.Location = new System.Drawing.Point(164, 234);
            this.fiyatb_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fiyatb_txt.Name = "fiyatb_txt";
            this.fiyatb_txt.Size = new System.Drawing.Size(220, 22);
            this.fiyatb_txt.TabIndex = 0;
            // 
            // fiyatbelirle_btn
            // 
            this.fiyatbelirle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fiyatbelirle_btn.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiyatbelirle_btn.Location = new System.Drawing.Point(179, 299);
            this.fiyatbelirle_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fiyatbelirle_btn.Name = "fiyatbelirle_btn";
            this.fiyatbelirle_btn.Size = new System.Drawing.Size(176, 46);
            this.fiyatbelirle_btn.TabIndex = 3;
            this.fiyatbelirle_btn.Text = "Onayla";
            this.fiyatbelirle_btn.UseVisualStyleBackColor = false;
            this.fiyatbelirle_btn.Click += new System.EventHandler(this.fiyatbelirle_btn_Click);
            // 
            // cikisfiyatbelirle
            // 
            this.cikisfiyatbelirle.BackColor = System.Drawing.Color.Transparent;
            this.cikisfiyatbelirle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisfiyatbelirle.FlatAppearance.BorderSize = 0;
            this.cikisfiyatbelirle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisfiyatbelirle.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisfiyatbelirle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cikisfiyatbelirle.Location = new System.Drawing.Point(497, -6);
            this.cikisfiyatbelirle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikisfiyatbelirle.Name = "cikisfiyatbelirle";
            this.cikisfiyatbelirle.Size = new System.Drawing.Size(43, 44);
            this.cikisfiyatbelirle.TabIndex = 9;
            this.cikisfiyatbelirle.Text = "X";
            this.cikisfiyatbelirle.UseVisualStyleBackColor = false;
            this.cikisfiyatbelirle.Click += new System.EventHandler(this.cikisfiyatbelirle_Click);
            // 
            // fiyatb_lbl
            // 
            this.fiyatb_lbl.AutoSize = true;
            this.fiyatb_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fiyatb_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiyatb_lbl.Location = new System.Drawing.Point(147, 136);
            this.fiyatb_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fiyatb_lbl.Name = "fiyatb_lbl";
            this.fiyatb_lbl.Size = new System.Drawing.Size(257, 66);
            this.fiyatb_lbl.TabIndex = 10;
            this.fiyatb_lbl.Text = "   Hangi Fiyattan \r\nalmak istiyorsunuz?";
            // 
            // fiyatbelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 492);
            this.Controls.Add(this.fiyatb_lbl);
            this.Controls.Add(this.cikisfiyatbelirle);
            this.Controls.Add(this.fiyatbelirle_btn);
            this.Controls.Add(this.fiyatb_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fiyatbelirle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fiyatbelirle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fiyatb_txt;
        private System.Windows.Forms.Button fiyatbelirle_btn;
        private System.Windows.Forms.Button cikisfiyatbelirle;
        private System.Windows.Forms.Label fiyatb_lbl;
    }
}