namespace UI.HasteneOtomasyonu
{
    partial class UIUser
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.pnlKullanıcıBilgileri = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkYetkiliKullanici = new System.Windows.Forms.CheckBox();
            this.cmbMedeniHal = new System.Windows.Forms.ComboBox();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.dtIseBaslama = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButonlar.SuspendLayout();
            this.pnlKullanıcıBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Olive;
            this.btnTemizle.Location = new System.Drawing.Point(21, 11);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 51);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButonlar.Controls.Add(this.btnCikis);
            this.pnlButonlar.Controls.Add(this.btnSil);
            this.pnlButonlar.Controls.Add(this.btnTemizle);
            this.pnlButonlar.Controls.Add(this.btnGüncelle);
            this.pnlButonlar.Location = new System.Drawing.Point(22, 451);
            this.pnlButonlar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(669, 78);
            this.pnlButonlar.TabIndex = 73;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Maroon;
            this.btnCikis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCikis.Location = new System.Drawing.Point(472, 11);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(93, 51);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Green;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSil.Location = new System.Drawing.Point(224, 11);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(62, 51);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGüncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.Yellow;
            this.btnGüncelle.Location = new System.Drawing.Point(122, 11);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(98, 51);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // pnlKullanıcıBilgileri
            // 
            this.pnlKullanıcıBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKullanıcıBilgileri.Controls.Add(this.txtSifre);
            this.pnlKullanıcıBilgileri.Controls.Add(this.label19);
            this.pnlKullanıcıBilgileri.Controls.Add(this.txtKullaniciAdi);
            this.pnlKullanıcıBilgileri.Controls.Add(this.label18);
            this.pnlKullanıcıBilgileri.Location = new System.Drawing.Point(22, 403);
            this.pnlKullanıcıBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKullanıcıBilgileri.Name = "pnlKullanıcıBilgileri";
            this.pnlKullanıcıBilgileri.Size = new System.Drawing.Size(669, 44);
            this.pnlKullanıcıBilgileri.TabIndex = 72;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(470, 8);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.MaxLength = 20;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(152, 23);
            this.txtSifre.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(425, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 18);
            this.label19.TabIndex = 38;
            this.label19.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(138, 10);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciAdi.MaxLength = 50;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(146, 23);
            this.txtKullaniciAdi.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(45, 12);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 18);
            this.label18.TabIndex = 36;
            this.label18.Text = "Kullanıcı Adı:";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(22, 293);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(669, 105);
            this.txtAdres.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(32, 263);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 18);
            this.label17.TabIndex = 70;
            this.label17.Text = "Adres:";
            // 
            // chkYetkiliKullanici
            // 
            this.chkYetkiliKullanici.AutoSize = true;
            this.chkYetkiliKullanici.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkYetkiliKullanici.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkYetkiliKullanici.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkYetkiliKullanici.Location = new System.Drawing.Point(203, 241);
            this.chkYetkiliKullanici.Margin = new System.Windows.Forms.Padding(2);
            this.chkYetkiliKullanici.Name = "chkYetkiliKullanici";
            this.chkYetkiliKullanici.Size = new System.Drawing.Size(124, 22);
            this.chkYetkiliKullanici.TabIndex = 69;
            this.chkYetkiliKullanici.Text = " yetkili kullanıcı";
            this.chkYetkiliKullanici.UseVisualStyleBackColor = true;
            // 
            // cmbMedeniHal
            // 
            this.cmbMedeniHal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMedeniHal.FormattingEnabled = true;
            this.cmbMedeniHal.Items.AddRange(new object[] {
            "EVLİ",
            "BEKAR",
            "DİĞER"});
            this.cmbMedeniHal.Location = new System.Drawing.Point(620, 234);
            this.cmbMedeniHal.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMedeniHal.Name = "cmbMedeniHal";
            this.cmbMedeniHal.Size = new System.Drawing.Size(54, 23);
            this.cmbMedeniHal.TabIndex = 68;
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Items.AddRange(new object[] {
            "ARH-",
            "ARH+",
            "ABRH+",
            "0RH-",
            "0RH+",
            "ABRH-"});
            this.cmbKanGrubu.Location = new System.Drawing.Point(508, 240);
            this.cmbKanGrubu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(54, 23);
            this.cmbKanGrubu.TabIndex = 67;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(508, 212);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(54, 23);
            this.cmbCinsiyet.TabIndex = 66;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(603, 210);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 65;
            this.label16.Text = "Medeni Hali:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(422, 239);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 18);
            this.label15.TabIndex = 64;
            this.label15.Text = "Kan Grubu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(435, 214);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 18);
            this.label14.TabIndex = 63;
            this.label14.Text = "Cinsiyeti:";
            // 
            // dtDogumTarih
            // 
            this.dtDogumTarih.Location = new System.Drawing.Point(507, 183);
            this.dtDogumTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtDogumTarih.Name = "dtDogumTarih";
            this.dtDogumTarih.Size = new System.Drawing.Size(182, 20);
            this.dtDogumTarih.TabIndex = 62;
            // 
            // dtIseBaslama
            // 
            this.dtIseBaslama.Location = new System.Drawing.Point(509, 151);
            this.dtIseBaslama.Margin = new System.Windows.Forms.Padding(2);
            this.dtIseBaslama.Name = "dtIseBaslama";
            this.dtIseBaslama.Size = new System.Drawing.Size(182, 20);
            this.dtIseBaslama.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(410, 182);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 18);
            this.label13.TabIndex = 60;
            this.label13.Text = "Dogum Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(417, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "İşe Başlama:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(441, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 58;
            this.label11.Text = "Unvanı:";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(509, 18);
            this.cmbUnvan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(182, 23);
            this.cmbUnvan.TabIndex = 57;
            this.cmbUnvan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUnvan_KeyPress);
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Location = new System.Drawing.Point(509, 116);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaas.MaxLength = 20;
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(182, 23);
            this.txtMaas.TabIndex = 56;
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(452, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 55;
            this.label10.Text = "Maaş:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(509, 81);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.MaxLength = 20;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(182, 23);
            this.txtSoyad.TabIndex = 54;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUnvan_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(444, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Soyadı:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(509, 49);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.MaxLength = 20;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(182, 23);
            this.txtAd.TabIndex = 52;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUnvan_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(464, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "Adı:";
            // 
            // txtGsm
            // 
            this.txtGsm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGsm.Location = new System.Drawing.Point(167, 210);
            this.txtGsm.Margin = new System.Windows.Forms.Padding(2);
            this.txtGsm.MaxLength = 11;
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(160, 23);
            this.txtGsm.TabIndex = 50;
            this.txtGsm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(114, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "GSM:";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(167, 180);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelNo.MaxLength = 11;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(160, 23);
            this.txtTelNo.TabIndex = 48;
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(76, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Telefon No:";
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnneAdi.Location = new System.Drawing.Point(167, 148);
            this.txtAnneAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnneAdi.MaxLength = 20;
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(160, 23);
            this.txtAnneAdi.TabIndex = 46;
            this.txtAnneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(87, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Anne Adı:";
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBabaAdi.Location = new System.Drawing.Point(167, 116);
            this.txtBabaAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtBabaAdi.MaxLength = 20;
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(160, 23);
            this.txtBabaAdi.TabIndex = 44;
            this.txtBabaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(90, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Baba Adı:";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogumYeri.Location = new System.Drawing.Point(167, 83);
            this.txtDogumYeri.Margin = new System.Windows.Forms.Padding(2);
            this.txtDogumYeri.MaxLength = 50;
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(160, 23);
            this.txtDogumYeri.TabIndex = 42;
            this.txtDogumYeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(73, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Doğum Yeri:";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(167, 51);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(160, 23);
            this.txtTcNo.TabIndex = 40;
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "T.C Kimlik Numarası:";
            // 
            // txtKullaniciKod
            // 
            this.txtKullaniciKod.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciKod.Location = new System.Drawing.Point(167, 22);
            this.txtKullaniciKod.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciKod.MaxLength = 20;
            this.txtKullaniciKod.Name = "txtKullaniciKod";
            this.txtKullaniciKod.Size = new System.Drawing.Size(160, 23);
            this.txtKullaniciKod.TabIndex = 38;
            this.txtKullaniciKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciKod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kullanıcı Kodu:";
            // 
            // UIUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(714, 553);
            this.Controls.Add(this.pnlButonlar);
            this.Controls.Add(this.pnlKullanıcıBilgileri);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.chkYetkiliKullanici);
            this.Controls.Add(this.cmbMedeniHal);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtDogumTarih);
            this.Controls.Add(this.dtIseBaslama);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnneAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBabaAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciKod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIUser";
            this.Text = "Kullanıcı Tanıtma";
            this.Load += new System.EventHandler(this.UIUser_Load);
            this.pnlButonlar.ResumeLayout(false);
            this.pnlKullanıcıBilgileri.ResumeLayout(false);
            this.pnlKullanıcıBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Panel pnlKullanıcıBilgileri;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkYetkiliKullanici;
        private System.Windows.Forms.ComboBox cmbMedeniHal;
        private System.Windows.Forms.ComboBox cmbKanGrubu;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtDogumTarih;
        private System.Windows.Forms.DateTimePicker dtIseBaslama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnneAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciKod;
        private System.Windows.Forms.Label label1;
    }
}