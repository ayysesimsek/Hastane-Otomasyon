namespace UI.HasteneOtomasyonu
{
    partial class UIPolyclinicIdentification
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
            this.chcGecerlilik = new System.Windows.Forms.CheckBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chcGecerlilik
            // 
            this.chcGecerlilik.AutoSize = true;
            this.chcGecerlilik.BackColor = System.Drawing.Color.Transparent;
            this.chcGecerlilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcGecerlilik.Location = new System.Drawing.Point(198, 57);
            this.chcGecerlilik.Name = "chcGecerlilik";
            this.chcGecerlilik.Size = new System.Drawing.Size(140, 19);
            this.chcGecerlilik.TabIndex = 5;
            this.chcGecerlilik.Text = "Geçerli / Geçersiz";
            this.chcGecerlilik.UseVisualStyleBackColor = false;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPoliklinik.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(190, 30);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(153, 23);
            this.cmbPoliklinik.TabIndex = 4;
            this.cmbPoliklinik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPoliklinik_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(219, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poliklinik Adı";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(145, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "( Lütfen ilgili polikliniğe gitmek için adı seçip \"ENTER\" a basınız )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::UI.HasteneOtomasyonu.Properties.Resources.th;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UIPolyclinicIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(387, 142);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chcGecerlilik);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIPolyclinicIdentification";
            this.Text = "SOHATS - Poliklinik Tanıtma";
            this.Load += new System.EventHandler(this.UIPolyclinicIdentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chcGecerlilik;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}