namespace UI.HasteneOtomasyonu
{
    partial class UIPatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPatientInfo));
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.pnlEkleme = new System.Windows.Forms.Panel();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtSıraNo = new System.Windows.Forms.TextBox();
            this.nmMiktar = new System.Windows.Forms.NumericUpDown();
            this.cmbDrKod = new System.Windows.Forms.ComboBox();
            this.cmbYapilanIslem = new System.Windows.Forms.ComboBox();
            this.cmbPolikilinik = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlAltButonlar = new System.Windows.Forms.Panel();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnBaskiOnIzleme = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.BirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblToplamTutarSonuc = new System.Windows.Forms.Label();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgYapilanIslemSonuc = new System.Windows.Forms.DataGridView();
            this.Polikilinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SıraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yapılanislem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEnUst = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSevk = new System.Windows.Forms.TextBox();
            this.btnHastaBilgisi = new System.Windows.Forms.Button();
            this.cmbOncekiIslem = new System.Windows.Forms.ComboBox();
            this.lblSaglıkOcagıAd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDosyaNumara = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtDogumYer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbYapilanTahlilVeIslemler = new System.Windows.Forms.GroupBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pnlEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiktar)).BeginInit();
            this.pnlAltButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgYapilanIslemSonuc)).BeginInit();
            this.pnlEnUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbYapilanTahlilVeIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(469, 526);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(97, 19);
            this.lblToplamTutar.TabIndex = 24;
            this.lblToplamTutar.Text = "Toplam Tutar:";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEkleme
            // 
            this.pnlEkleme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEkleme.Controls.Add(this.txtBirimFiyat);
            this.pnlEkleme.Controls.Add(this.txtSıraNo);
            this.pnlEkleme.Controls.Add(this.nmMiktar);
            this.pnlEkleme.Controls.Add(this.cmbDrKod);
            this.pnlEkleme.Controls.Add(this.cmbYapilanIslem);
            this.pnlEkleme.Controls.Add(this.cmbPolikilinik);
            this.pnlEkleme.Controls.Add(this.label13);
            this.pnlEkleme.Controls.Add(this.label12);
            this.pnlEkleme.Controls.Add(this.label11);
            this.pnlEkleme.Controls.Add(this.label10);
            this.pnlEkleme.Controls.Add(this.label9);
            this.pnlEkleme.Controls.Add(this.label8);
            this.pnlEkleme.Location = new System.Drawing.Point(0, 215);
            this.pnlEkleme.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEkleme.Name = "pnlEkleme";
            this.pnlEkleme.Size = new System.Drawing.Size(638, 54);
            this.pnlEkleme.TabIndex = 21;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(537, 27);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirimFiyat.MaxLength = 20;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(95, 20);
            this.txtBirimFiyat.TabIndex = 11;
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyat_KeyPress);
            // 
            // txtSıraNo
            // 
            this.txtSıraNo.Location = new System.Drawing.Point(110, 28);
            this.txtSıraNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSıraNo.MaxLength = 10;
            this.txtSıraNo.Name = "txtSıraNo";
            this.txtSıraNo.Size = new System.Drawing.Size(93, 20);
            this.txtSıraNo.TabIndex = 10;
            this.txtSıraNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSıraNo_KeyPress);
            // 
            // nmMiktar
            // 
            this.nmMiktar.Location = new System.Drawing.Point(447, 28);
            this.nmMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.nmMiktar.Name = "nmMiktar";
            this.nmMiktar.Size = new System.Drawing.Size(75, 20);
            this.nmMiktar.TabIndex = 9;
            // 
            // cmbDrKod
            // 
            this.cmbDrKod.FormattingEnabled = true;
            this.cmbDrKod.Location = new System.Drawing.Point(359, 28);
            this.cmbDrKod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDrKod.Name = "cmbDrKod";
            this.cmbDrKod.Size = new System.Drawing.Size(78, 21);
            this.cmbDrKod.TabIndex = 8;
            this.cmbDrKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPolikilinik_KeyPress);
            // 
            // cmbYapilanIslem
            // 
            this.cmbYapilanIslem.FormattingEnabled = true;
            this.cmbYapilanIslem.Items.AddRange(new object[] {
            "yeni işlem",
            "kan tahlili",
            "a tahlili",
            "b tahlili",
            "c tahlili",
            "muayene"});
            this.cmbYapilanIslem.Location = new System.Drawing.Point(221, 28);
            this.cmbYapilanIslem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYapilanIslem.Name = "cmbYapilanIslem";
            this.cmbYapilanIslem.Size = new System.Drawing.Size(120, 21);
            this.cmbYapilanIslem.TabIndex = 7;
            this.cmbYapilanIslem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPolikilinik_KeyPress);
            // 
            // cmbPolikilinik
            // 
            this.cmbPolikilinik.FormattingEnabled = true;
            this.cmbPolikilinik.Location = new System.Drawing.Point(2, 28);
            this.cmbPolikilinik.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPolikilinik.Name = "cmbPolikilinik";
            this.cmbPolikilinik.Size = new System.Drawing.Size(92, 21);
            this.cmbPolikilinik.TabIndex = 6;
            this.cmbPolikilinik.SelectedIndexChanged += new System.EventHandler(this.cmbPolikilinik_SelectedIndexChanged);
            this.cmbPolikilinik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPolikilinik_KeyPress);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(538, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Birim Fiyat";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(447, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Miktar";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(359, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Dr.Kodu";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(220, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Yapılan İşlem";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(109, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sıra No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Polikilinik";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAltButonlar
            // 
            this.pnlAltButonlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAltButonlar.Controls.Add(this.btnCıkıs);
            this.pnlAltButonlar.Controls.Add(this.btnBaskiOnIzleme);
            this.pnlAltButonlar.Controls.Add(this.btnYazdir);
            this.pnlAltButonlar.Controls.Add(this.btnTaburcu);
            this.pnlAltButonlar.Controls.Add(this.btnSecSil);
            this.pnlAltButonlar.Controls.Add(this.btnYeni);
            this.pnlAltButonlar.Location = new System.Drawing.Point(0, 547);
            this.pnlAltButonlar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAltButonlar.Name = "pnlAltButonlar";
            this.pnlAltButonlar.Size = new System.Drawing.Size(747, 72);
            this.pnlAltButonlar.TabIndex = 23;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Maroon;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCıkıs.Location = new System.Drawing.Point(641, 3);
            this.btnCıkıs.Margin = new System.Windows.Forms.Padding(2);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(95, 47);
            this.btnCıkıs.TabIndex = 12;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnBaskiOnIzleme
            // 
            this.btnBaskiOnIzleme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaskiOnIzleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaskiOnIzleme.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBaskiOnIzleme.Location = new System.Drawing.Point(338, 3);
            this.btnBaskiOnIzleme.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaskiOnIzleme.Name = "btnBaskiOnIzleme";
            this.btnBaskiOnIzleme.Size = new System.Drawing.Size(136, 46);
            this.btnBaskiOnIzleme.TabIndex = 11;
            this.btnBaskiOnIzleme.Text = "Baskı Önizleme";
            this.btnBaskiOnIzleme.UseVisualStyleBackColor = false;
            this.btnBaskiOnIzleme.Click += new System.EventHandler(this.btnBaskiOnIzleme_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(255, 2);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(79, 47);
            this.btnYazdir.TabIndex = 10;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaburcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaburcu.ForeColor = System.Drawing.Color.Yellow;
            this.btnTaburcu.Location = new System.Drawing.Point(174, 3);
            this.btnTaburcu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(77, 47);
            this.btnTaburcu.TabIndex = 9;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = false;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSecSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSecSil.Location = new System.Drawing.Point(90, 4);
            this.btnSecSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(80, 47);
            this.btnSecSil.TabIndex = 8;
            this.btnSecSil.Text = "Seç-Sil";
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(5, 4);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(80, 47);
            this.btnYeni.TabIndex = 7;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.HeaderText = "Birim Fiyatı";
            this.BirimFiyati.Name = "BirimFiyati";
            // 
            // lblToplamTutarSonuc
            // 
            this.lblToplamTutarSonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblToplamTutarSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutarSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamTutarSonuc.Location = new System.Drawing.Point(561, 526);
            this.lblToplamTutarSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamTutarSonuc.Name = "lblToplamTutarSonuc";
            this.lblToplamTutarSonuc.Size = new System.Drawing.Size(188, 19);
            this.lblToplamTutarSonuc.TabIndex = 25;
            this.lblToplamTutarSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // dtgYapilanIslemSonuc
            // 
            this.dtgYapilanIslemSonuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgYapilanIslemSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgYapilanIslemSonuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Polikilinik,
            this.SıraNo,
            this.Saat,
            this.Yapılanislem,
            this.DrKodu,
            this.Miktar,
            this.BirimFiyati});
            this.dtgYapilanIslemSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgYapilanIslemSonuc.Location = new System.Drawing.Point(2, 15);
            this.dtgYapilanIslemSonuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtgYapilanIslemSonuc.Name = "dtgYapilanIslemSonuc";
            this.dtgYapilanIslemSonuc.RowTemplate.Height = 24;
            this.dtgYapilanIslemSonuc.Size = new System.Drawing.Size(747, 237);
            this.dtgYapilanIslemSonuc.TabIndex = 0;
            // 
            // Polikilinik
            // 
            this.Polikilinik.HeaderText = "Polikilinik";
            this.Polikilinik.Name = "Polikilinik";
            // 
            // SıraNo
            // 
            this.SıraNo.HeaderText = "Sıra No";
            this.SıraNo.Name = "SıraNo";
            // 
            // Saat
            // 
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            // 
            // Yapılanislem
            // 
            this.Yapılanislem.HeaderText = "Yapılan İşlem";
            this.Yapılanislem.Name = "Yapılanislem";
            // 
            // DrKodu
            // 
            this.DrKodu.HeaderText = "Dr.Kodu";
            this.DrKodu.Name = "DrKodu";
            // 
            // pnlEnUst
            // 
            this.pnlEnUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEnUst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEnUst.Controls.Add(this.pictureBox1);
            this.pnlEnUst.Controls.Add(this.btnGo);
            this.pnlEnUst.Controls.Add(this.button1);
            this.pnlEnUst.Controls.Add(this.txtSevk);
            this.pnlEnUst.Controls.Add(this.btnHastaBilgisi);
            this.pnlEnUst.Controls.Add(this.cmbOncekiIslem);
            this.pnlEnUst.Controls.Add(this.lblSaglıkOcagıAd);
            this.pnlEnUst.Controls.Add(this.label6);
            this.pnlEnUst.Controls.Add(this.label5);
            this.pnlEnUst.Controls.Add(this.label4);
            this.pnlEnUst.Controls.Add(this.txtDosyaNumara);
            this.pnlEnUst.Controls.Add(this.txtTcNo);
            this.pnlEnUst.Controls.Add(this.txtDogumYer);
            this.pnlEnUst.Controls.Add(this.label1);
            this.pnlEnUst.Controls.Add(this.label3);
            this.pnlEnUst.Controls.Add(this.txtKAdi);
            this.pnlEnUst.Controls.Add(this.label2);
            this.pnlEnUst.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlEnUst.Location = new System.Drawing.Point(0, 0);
            this.pnlEnUst.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEnUst.Name = "pnlEnUst";
            this.pnlEnUst.Size = new System.Drawing.Size(752, 210);
            this.pnlEnUst.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::UI.HasteneOtomasyonu.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGo.Image = global::UI.HasteneOtomasyonu.Properties.Resources.btnico_hastagit;
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGo.Location = new System.Drawing.Point(283, 164);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(76, 25);
            this.btnGo.TabIndex = 26;
            this.btnGo.Text = "     Git";
            this.btnGo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = global::UI.HasteneOtomasyonu.Properties.Resources.btnico_hastabul;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(283, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "      Bul";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSevk
            // 
            this.txtSevk.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSevk.Location = new System.Drawing.Point(167, 133);
            this.txtSevk.Margin = new System.Windows.Forms.Padding(2);
            this.txtSevk.MaxLength = 10;
            this.txtSevk.Name = "txtSevk";
            this.txtSevk.Size = new System.Drawing.Size(111, 26);
            this.txtSevk.TabIndex = 24;
            // 
            // btnHastaBilgisi
            // 
            this.btnHastaBilgisi.BackColor = System.Drawing.SystemColors.Window;
            this.btnHastaBilgisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHastaBilgisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaBilgisi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaBilgisi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHastaBilgisi.Image = global::UI.HasteneOtomasyonu.Properties.Resources.btnico_hastabilgisi;
            this.btnHastaBilgisi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHastaBilgisi.Location = new System.Drawing.Point(604, 10);
            this.btnHastaBilgisi.Name = "btnHastaBilgisi";
            this.btnHastaBilgisi.Size = new System.Drawing.Size(141, 44);
            this.btnHastaBilgisi.TabIndex = 23;
            this.btnHastaBilgisi.Text = "Hasta Bilgisi";
            this.btnHastaBilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaBilgisi.UseVisualStyleBackColor = false;
            this.btnHastaBilgisi.Click += new System.EventHandler(this.btnHastaBilgisi_Click);
            // 
            // cmbOncekiIslem
            // 
            this.cmbOncekiIslem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOncekiIslem.FormattingEnabled = true;
            this.cmbOncekiIslem.Location = new System.Drawing.Point(167, 163);
            this.cmbOncekiIslem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOncekiIslem.MaxLength = 50;
            this.cmbOncekiIslem.Name = "cmbOncekiIslem";
            this.cmbOncekiIslem.Size = new System.Drawing.Size(111, 26);
            this.cmbOncekiIslem.TabIndex = 22;
            this.cmbOncekiIslem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOncekiIslem_KeyPress);
            // 
            // lblSaglıkOcagıAd
            // 
            this.lblSaglıkOcagıAd.AutoSize = true;
            this.lblSaglıkOcagıAd.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaglıkOcagıAd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSaglıkOcagıAd.Location = new System.Drawing.Point(160, 15);
            this.lblSaglıkOcagıAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaglıkOcagıAd.Name = "lblSaglıkOcagıAd";
            this.lblSaglıkOcagıAd.Size = new System.Drawing.Size(439, 39);
            this.lblSaglıkOcagıAd.TabIndex = 21;
            this.lblSaglıkOcagıAd.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Önceki İşlemler:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sevk Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dosya Numarası : ";
            // 
            // txtDosyaNumara
            // 
            this.txtDosyaNumara.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaNumara.Location = new System.Drawing.Point(167, 103);
            this.txtDosyaNumara.Margin = new System.Windows.Forms.Padding(2);
            this.txtDosyaNumara.MaxLength = 10;
            this.txtDosyaNumara.Name = "txtDosyaNumara";
            this.txtDosyaNumara.Size = new System.Drawing.Size(111, 26);
            this.txtDosyaNumara.TabIndex = 13;
            this.txtDosyaNumara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDosyaNumara_KeyDown);
            this.txtDosyaNumara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDosyaNumara_KeyPress);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(580, 133);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(154, 26);
            this.txtTcNo.TabIndex = 9;
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // txtDogumYer
            // 
            this.txtDogumYer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogumYer.Location = new System.Drawing.Point(580, 163);
            this.txtDogumYer.Margin = new System.Windows.Forms.Padding(2);
            this.txtDogumYer.MaxLength = 20;
            this.txtDogumYer.Name = "txtDogumYer";
            this.txtDogumYer.Size = new System.Drawing.Size(154, 26);
            this.txtDogumYer.TabIndex = 11;
            this.txtDogumYer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(464, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(471, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doğum Yeri:";
            // 
            // txtKAdi
            // 
            this.txtKAdi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKAdi.Location = new System.Drawing.Point(580, 103);
            this.txtKAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKAdi.MaxLength = 20;
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(154, 26);
            this.txtKAdi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(415, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C Kimlik Numarası:";
            // 
            // grbYapilanTahlilVeIslemler
            // 
            this.grbYapilanTahlilVeIslemler.Controls.Add(this.dtgYapilanIslemSonuc);
            this.grbYapilanTahlilVeIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbYapilanTahlilVeIslemler.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbYapilanTahlilVeIslemler.Location = new System.Drawing.Point(0, 273);
            this.grbYapilanTahlilVeIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.grbYapilanTahlilVeIslemler.Name = "grbYapilanTahlilVeIslemler";
            this.grbYapilanTahlilVeIslemler.Padding = new System.Windows.Forms.Padding(2);
            this.grbYapilanTahlilVeIslemler.Size = new System.Drawing.Size(751, 254);
            this.grbYapilanTahlilVeIslemler.TabIndex = 20;
            this.grbYapilanTahlilVeIslemler.TabStop = false;
            this.grbYapilanTahlilVeIslemler.Text = "Yapılan Tahlil ve İşlemler";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::UI.HasteneOtomasyonu.Properties.Resources.btnico_hastabilgisiekle;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(643, 215);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 49);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // UIPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 642);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.pnlEkleme);
            this.Controls.Add(this.pnlAltButonlar);
            this.Controls.Add(this.lblToplamTutarSonuc);
            this.Controls.Add(this.pnlEnUst);
            this.Controls.Add(this.grbYapilanTahlilVeIslemler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIPatientInfo";
            this.Text = "Hasta İşlemleri";
            this.Load += new System.EventHandler(this.UIPatientInfo_Load);
            this.pnlEkleme.ResumeLayout(false);
            this.pnlEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiktar)).EndInit();
            this.pnlAltButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgYapilanIslemSonuc)).EndInit();
            this.pnlEnUst.ResumeLayout(false);
            this.pnlEnUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbYapilanTahlilVeIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Panel pnlEkleme;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtSıraNo;
        private System.Windows.Forms.NumericUpDown nmMiktar;
        private System.Windows.Forms.ComboBox cmbDrKod;
        private System.Windows.Forms.ComboBox cmbYapilanIslem;
        private System.Windows.Forms.ComboBox cmbPolikilinik;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlAltButonlar;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnBaskiOnIzleme;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati;
        private System.Windows.Forms.Label lblToplamTutarSonuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridView dtgYapilanIslemSonuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polikilinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn SıraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yapılanislem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrKodu;
        private System.Windows.Forms.Panel pnlEnUst;
        private System.Windows.Forms.ComboBox cmbOncekiIslem;
        private System.Windows.Forms.Label lblSaglıkOcagıAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDosyaNumara;
        private System.Windows.Forms.GroupBox grbYapilanTahlilVeIslemler;
        private System.Windows.Forms.Button btnHastaBilgisi;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtDogumYer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSevk;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}