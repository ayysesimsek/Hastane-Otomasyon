namespace UI.HasteneOtomasyonu
{
    partial class UIDischarged
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
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbVazgec = new System.Windows.Forms.PictureBox();
            this.pbTaburcu = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVazgec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaburcu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.ForeColor = System.Drawing.Color.Pink;
            this.txtToplamTutar.Location = new System.Drawing.Point(132, 129);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtToplamTutar.MaxLength = 20;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(286, 27);
            this.txtToplamTutar.TabIndex = 31;
            this.txtToplamTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToplamTutar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(19, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Toplam Tutar:";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeSekli.ForeColor = System.Drawing.Color.Pink;
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Location = new System.Drawing.Point(132, 100);
            this.cmbOdemeSekli.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(286, 27);
            this.cmbOdemeSekli.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ödeme Şekli";
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtCikisTarihi.Location = new System.Drawing.Point(132, 71);
            this.dtCikisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(286, 27);
            this.dtCikisTarihi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // dtSevkTarihi
            // 
            this.dtSevkTarihi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtSevkTarihi.Location = new System.Drawing.Point(132, 42);
            this.dtSevkTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtSevkTarihi.Name = "dtSevkTarihi";
            this.dtSevkTarihi.Size = new System.Drawing.Size(286, 27);
            this.dtSevkTarihi.TabIndex = 25;
            this.dtSevkTarihi.ValueChanged += new System.EventHandler(this.dtSevkTarihi_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sevk Tarihi:";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaNo.ForeColor = System.Drawing.Color.Pink;
            this.txtDosyaNo.Location = new System.Drawing.Point(132, 13);
            this.txtDosyaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDosyaNo.MaxLength = 10;
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(286, 27);
            this.txtDosyaNo.TabIndex = 23;
            this.txtDosyaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDosyaNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dosya No:";
            // 
            // pbVazgec
            // 
            this.pbVazgec.BackColor = System.Drawing.Color.Transparent;
            this.pbVazgec.Image = global::UI.HasteneOtomasyonu.Properties.Resources.btnico_vazgeç;
            this.pbVazgec.Location = new System.Drawing.Point(23, 177);
            this.pbVazgec.Name = "pbVazgec";
            this.pbVazgec.Size = new System.Drawing.Size(152, 89);
            this.pbVazgec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVazgec.TabIndex = 35;
            this.pbVazgec.TabStop = false;
            this.pbVazgec.Click += new System.EventHandler(this.pbVazgec_Click);
            // 
            // pbTaburcu
            // 
            this.pbTaburcu.BackColor = System.Drawing.Color.Transparent;
            this.pbTaburcu.Image = global::UI.HasteneOtomasyonu.Properties.Resources.btnico_hastataburcu1;
            this.pbTaburcu.Location = new System.Drawing.Point(266, 177);
            this.pbTaburcu.Name = "pbTaburcu";
            this.pbTaburcu.Size = new System.Drawing.Size(152, 89);
            this.pbTaburcu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTaburcu.TabIndex = 34;
            this.pbTaburcu.TabStop = false;
            this.pbTaburcu.Click += new System.EventHandler(this.pbTaburcu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(77, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Vazgeç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label7.Location = new System.Drawing.Point(314, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Taburcu Et";
            // 
            // UIDischarged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(443, 293);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbVazgec);
            this.Controls.Add(this.pbTaburcu);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtCikisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtSevkTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDosyaNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIDischarged";
            this.Text = "SOHATS - Taburcu";
            this.Load += new System.EventHandler(this.UIDischarged_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVazgec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaburcu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSevkTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTaburcu;
        private System.Windows.Forms.PictureBox pbVazgec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}