namespace UI.HasteneOtomasyonu
{
    partial class UIUserIdentification
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
            this.btnYeniKullaniciEkle = new System.Windows.Forms.Button();
            this.cmbKullaniciKodu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniKullaniciEkle
            // 
            this.btnYeniKullaniciEkle.BackColor = System.Drawing.Color.Maroon;
            this.btnYeniKullaniciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKullaniciEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYeniKullaniciEkle.Location = new System.Drawing.Point(2, 145);
            this.btnYeniKullaniciEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            this.btnYeniKullaniciEkle.Size = new System.Drawing.Size(354, 66);
            this.btnYeniKullaniciEkle.TabIndex = 5;
            this.btnYeniKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnYeniKullaniciEkle.Click += new System.EventHandler(this.btnYeniKullaniciEkle_Click);
            // 
            // cmbKullaniciKodu
            // 
            this.cmbKullaniciKodu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKullaniciKodu.ForeColor = System.Drawing.Color.Maroon;
            this.cmbKullaniciKodu.FormattingEnabled = true;
            this.cmbKullaniciKodu.Items.AddRange(new object[] {
            "1"});
            this.cmbKullaniciKodu.Location = new System.Drawing.Point(163, 49);
            this.cmbKullaniciKodu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKullaniciKodu.Name = "cmbKullaniciKodu";
            this.cmbKullaniciKodu.Size = new System.Drawing.Size(174, 23);
            this.cmbKullaniciKodu.TabIndex = 4;
            this.cmbKullaniciKodu.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciKodu_SelectedIndexChanged);
            this.cmbKullaniciKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbKullaniciKodu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(167, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Kodu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::UI.HasteneOtomasyonu.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(159, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "( İlgili kullanıcıya geçmek için  kodu seçip \"ENTER\"a basınız )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UIUserIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(355, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYeniKullaniciEkle);
            this.Controls.Add(this.cmbKullaniciKodu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIUserIdentification";
            this.Text = "Kullanıcı Tanıt";
            this.Load += new System.EventHandler(this.UIUserIdentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKullaniciEkle;
        private System.Windows.Forms.ComboBox cmbKullaniciKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}