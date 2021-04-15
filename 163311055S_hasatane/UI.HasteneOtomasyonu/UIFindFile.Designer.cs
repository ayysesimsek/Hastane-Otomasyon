namespace UI.HasteneOtomasyonu
{
    partial class UIFindFile
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
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.cmbAramaKriter = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtgAramaSonuc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAramaSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBilgi
            // 
            this.txtBilgi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilgi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBilgi.Location = new System.Drawing.Point(310, 239);
            this.txtBilgi.Margin = new System.Windows.Forms.Padding(2);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(258, 27);
            this.txtBilgi.TabIndex = 55;
            // 
            // cmbAramaKriter
            // 
            this.cmbAramaKriter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAramaKriter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbAramaKriter.FormattingEnabled = true;
            this.cmbAramaKriter.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.cmbAramaKriter.Location = new System.Drawing.Point(28, 239);
            this.cmbAramaKriter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAramaKriter.Name = "cmbAramaKriter";
            this.cmbAramaKriter.Size = new System.Drawing.Size(255, 27);
            this.cmbAramaKriter.TabIndex = 50;
            this.cmbAramaKriter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAramaKriter_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(97, 205);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 23);
            this.label18.TabIndex = 49;
            this.label18.Text = "Arama Kriteri:";
            // 
            // dtgAramaSonuc
            // 
            this.dtgAramaSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAramaSonuc.Location = new System.Drawing.Point(-1, 288);
            this.dtgAramaSonuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtgAramaSonuc.Name = "dtgAramaSonuc";
            this.dtgAramaSonuc.RowTemplate.Height = 24;
            this.dtgAramaSonuc.Size = new System.Drawing.Size(592, 264);
            this.dtgAramaSonuc.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(369, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Aranacak Değer : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.HasteneOtomasyonu.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(393, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UIFindFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UI.HasteneOtomasyonu.Properties.Resources.indir1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(593, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.cmbAramaKriter);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtgAramaSonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIFindFile";
            this.Text = " <Dosya Bul>";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAramaSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.ComboBox cmbAramaKriter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dtgAramaSonuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}