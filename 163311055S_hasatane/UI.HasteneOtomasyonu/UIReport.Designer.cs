namespace UI.HasteneOtomasyonu
{
    partial class UIReport
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbTaburcu = new System.Windows.Forms.RadioButton();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.rbTaburcuDegil = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgYapilanIslemSonuc = new System.Windows.Forms.DataGridView();
            this.Polyclinic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgYapilanIslemSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(815, 382);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.rbTaburcu);
            this.panel1.Controls.Add(this.rbHepsi);
            this.panel1.Controls.Add(this.rbTaburcuDegil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.dateTimePickerBegin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 95);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSorgula);
            this.panel3.Controls.Add(this.btnYazdir);
            this.panel3.Controls.Add(this.btnTemizle);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(515, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 95);
            this.panel3.TabIndex = 7;
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSorgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorgula.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSorgula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSorgula.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.ForeColor = System.Drawing.Color.Black;
            this.btnSorgula.Location = new System.Drawing.Point(0, 0);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 95);
            this.btnSorgula.TabIndex = 3;
            this.btnSorgula.Text = "SORGULA";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnYazdir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.Black;
            this.btnYazdir.Location = new System.Drawing.Point(75, 0);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 95);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "YAZDIR";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTemizle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(150, 0);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 95);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(225, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 95);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbTaburcu
            // 
            this.rbTaburcu.AutoSize = true;
            this.rbTaburcu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTaburcu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbTaburcu.Location = new System.Drawing.Point(338, 12);
            this.rbTaburcu.Name = "rbTaburcu";
            this.rbTaburcu.Size = new System.Drawing.Size(123, 22);
            this.rbTaburcu.TabIndex = 6;
            this.rbTaburcu.TabStop = true;
            this.rbTaburcu.Text = "TABURCU OLAN";
            this.rbTaburcu.UseVisualStyleBackColor = true;
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbHepsi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbHepsi.Location = new System.Drawing.Point(338, 58);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(61, 22);
            this.rbHepsi.TabIndex = 5;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "HEPSİ";
            this.rbHepsi.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuDegil
            // 
            this.rbTaburcuDegil.AutoSize = true;
            this.rbTaburcuDegil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTaburcuDegil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbTaburcuDegil.Location = new System.Drawing.Point(338, 35);
            this.rbTaburcuDegil.Name = "rbTaburcuDegil";
            this.rbTaburcuDegil.Size = new System.Drawing.Size(151, 22);
            this.rbTaburcuDegil.TabIndex = 4;
            this.rbTaburcuDegil.TabStop = true;
            this.rbTaburcuDegil.Text = "TABURCU OLMAYAN";
            this.rbTaburcuDegil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(56, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "BİTİŞ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "BAŞLANGIÇ:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(116, 47);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBegin.Location = new System.Drawing.Point(116, 19);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBegin.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgYapilanIslemSonuc);
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 382);
            this.panel2.TabIndex = 3;
            // 
            // dtgYapilanIslemSonuc
            // 
            this.dtgYapilanIslemSonuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgYapilanIslemSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgYapilanIslemSonuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Polyclinic,
            this.Secret,
            this.Clock,
            this.Transaction,
            this.DrCode,
            this.Quantity,
            this.UnitPrice});
            this.dtgYapilanIslemSonuc.Location = new System.Drawing.Point(0, 92);
            this.dtgYapilanIslemSonuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtgYapilanIslemSonuc.Name = "dtgYapilanIslemSonuc";
            this.dtgYapilanIslemSonuc.RowTemplate.Height = 24;
            this.dtgYapilanIslemSonuc.Size = new System.Drawing.Size(815, 290);
            this.dtgYapilanIslemSonuc.TabIndex = 1;
            // 
            // Polyclinic
            // 
            this.Polyclinic.HeaderText = "Poliklinik";
            this.Polyclinic.Name = "Polyclinic";
            // 
            // Secret
            // 
            this.Secret.HeaderText = "Gizli";
            this.Secret.Name = "Secret";
            // 
            // Clock
            // 
            this.Clock.HeaderText = "Saat";
            this.Clock.Name = "Clock";
            // 
            // Transaction
            // 
            this.Transaction.HeaderText = "Yapılan İşlem";
            this.Transaction.Name = "Transaction";
            // 
            // DrCode
            // 
            this.DrCode.HeaderText = "Dr. Code";
            this.DrCode.Name = "DrCode";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Miktar";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Birim Fiyat";
            this.UnitPrice.Name = "UnitPrice";
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
            // UIReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(815, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIReport";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.UIReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgYapilanIslemSonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbTaburcu;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.RadioButton rbTaburcuDegil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSorgula;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridView dtgYapilanIslemSonuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polyclinic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}