using Business.SOHATS.HastaneOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Types.HastaneOtomasyonu;
using Types.HastaneOtomasyonu.Entitiy;

namespace UI.HasteneOtomasyonu
{
    public partial class UIPatientInfo : Form
    {
        #region CONSTRUCTOR
        public UIPatientInfo()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT - CLICK METOTLAR

        /// <summary>
        /// Ekle Butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            SevkTransactionMethod();
        }

        /// <summary>
        /// Yeni Butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            UIPatientInfo patient = new UIPatientInfo();
            patient.MdiParent = this.MdiParent;
            patient.Show();
            process.Location = new Point(500, 55);
        }

        /// <summary>
        /// Çıkış Butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        /// <summary>
        /// Hasta Bilgileri Ekranı Load kısmında gelecek ve oluşacak aksiyonlar yazılmıştır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIPatientInfo_Load(object sender, EventArgs e)
        {
            LoadToCombobox();
            txtSıraNo.Enabled = false;
        }

        /// <summary>
        /// Baskı Önizleme Butonunu basıldığında datagridde listelenen veriler önizlenmektedir .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaskiOnIzleme_Click(object sender, EventArgs e)
        {
            DataGridLoadData();
        }

        /// <summary>
        /// PritDocument --> Baskı önizlemesine basıldığında hangi verilerin gözükmesi ve geleceği bilgiler yer almakatdır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dtgYapilanIslemSonuc.Width, dtgYapilanIslemSonuc.Height);
            dtgYapilanIslemSonuc.DrawToBitmap(bitmap, new Rectangle(0, 40, dtgYapilanIslemSonuc.Width, dtgYapilanIslemSonuc.Height));
            e.Graphics.DrawString("Poliklinik : " + cmbPolikilinik.Text.ToUpper() +
                                  " Sıra No : " + txtSıraNo.Text.ToUpper() +
                                  " Yapılan İşlem : " + cmbYapilanIslem.Text.ToUpper() +
                                  " Dr.Kodu : " + cmbDrKod.Text.ToUpper() +
                                  " Miktar : " + nmMiktar.Value.ToString().ToUpper() +
                                  " Birim Fiyat : " + txtBirimFiyat.Text.ToUpper() +
                                  " Tarih" + DateTime.Now.ToShortDateString(),
                                  new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular),
                                  new SolidBrush(Color.Black),
                                  new Point(10, 10));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        #region Yazdır butonuna tıklanıldığında gerçekleşecek olaylar
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult writeOp;
            writeOp = printDialog1.ShowDialog();
            if (writeOp == DialogResult.OK)
                printDocument1.Print();
        }
        #endregion

        #region printDocument1 ' e tıklanıldığında 
        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("Yazdırma işlemi tamamlandı . ");
        }
        #endregion

        #region Bul butonuna tıklanıldığında filtreleme işlemleri ekranda belirecektir.
        private void button1_Click(object sender, EventArgs e)
        {
            UIFindFile find = new UIFindFile();
            find.MdiParent = this.MdiParent;
            find.Show();
        }
        #endregion

        #region Hasta bilgileri butonuna tıklanıldığında dolu olarak açılacak olan ekranın işlemleri yapılmaktadır.
        UIPatientProcess process = new UIPatientProcess();
        private void btnHastaBilgisi_Click(object sender, EventArgs e)
        {
            if (process.FillToArea(txtDosyaNumara.Text))
                MessageBox.Show(txtDosyaNumara.Text + " dosya numaralı kişinin bilgileri getiriliyor  .. \n\n" +
                                                      "Gelen hasta bilgileri üzerinde güncelleme - silme işlemlerini de gerçekleştirebilirsiniz .. ",
                                                      "Bildiri",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
            else
                MessageBox.Show(txtDosyaNumara.Text + " dosya numaralı kişi yok İsterseniz hasta ekleyebilirsiniz  ... ! ",
                                                      "Bildiri",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);

            process.MdiParent = this.MdiParent;
            process.Show();
            process.Location = new Point(130, 55);
        }
        #endregion

        #region Taburcu butonuna tıklanıldığında taburcu işlemlerinin yapılacağı ekran açılmaktadır .. 
        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            UIDischarged uIDischarged = new UIDischarged();
            if (uIDischarged.FillToArea(txtDosyaNumara.Text))
                MessageBox.Show(txtDosyaNumara.Text + " dosya numaralı kişi taburcu edilebilir .. ",
                                                      "Bildiri",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
            else
                MessageBox.Show(txtDosyaNumara.Text + " dosya numaralı kişi sevk edilmediğinden taburcu edilemez ... ! ",
                                                      "Bildiri",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
            uIDischarged.MdiParent = this.MdiParent;
            uIDischarged.Show();
            this.Close();
        }
        #endregion

        #region RAKAM / TEXT GİREMEM KONTROLÜ
        private void txtDosyaNumara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbOncekiIslem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDogumYer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void txtSıraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbPolikilinik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                          && !char.IsSeparator(e.KeyChar);
        }

        private void txtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        /// <summary>
        /// Dosya numarsı KeyDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDosyaNumara_KeyDown(object sender, KeyEventArgs e)
        
{
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                LoadToDataGridData();
            }
        }

        #region Poliklinik seçiminde sıra ataması yapılmaktadır ..
        private void cmbPolikilinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQueue();
        }
        #endregion

        #region Seç-Sil butonuna tıklaıldığında gerçekeleşecek olay 
        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz ?",
                                "Uyarı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SevkContract contract = new SevkContract();
                sevk deleted = new sevk();
                deleted = (sevk)dtgYapilanIslemSonuc.CurrentRow.DataBoundItem;
                if (deleted == null)
                {
                    MessageBox.Show("Silinecek kolunu seçiniz.");
                    return;
                }

                string ID = deleted.FileNumber;
                if (contract.DeletePatientDataGridSelected(ID))
                {
                    MessageBox.Show(deleted.FileNumber + " başarıyla silinmiştir. ");
                    LoadToDataGridData();
                }
            }
        }
        #endregion

        #region Git butonuna tıklanıldığında gerçekleşecek olay 
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cmbOncekiIslem.Text == "")
            {
                HastaContract contract = new HastaContract();
                List<hasta> hastas = new List<hasta>();
                hastas = contract.GetPatient(txtDosyaNumara.Text);
                dtgYapilanIslemSonuc.DataSource = hastas;
                CalculatedToTalAmount();
                DataGridHide();
            }
            else
            {
                LoadDoDataGridToShipmentDate();
                dtgYapilanIslemSonuc.AllowUserToAddRows = false;
                DataGridHide();
            }
        }
        #endregion

        #endregion

        #region METOTLAR

        #region Sevk işlemleri bilgilerini veritabanına ekleme işlemleri gerçekleşmektedir.
        public void SevkTransactionMethod()
        {
            #region Tüm alanlar dolu ise kayıt işlemi başarıyla gerçekleşir .. 
            if (!SaveEmptyControl())
            {
                sevk sevk = new sevk();
                sevk.ShipmentDate = txtSevk.Text;
                sevk.FileNumber = txtDosyaNumara.Text;
                sevk.Polyclinic = cmbPolikilinik.Text;
                sevk.Clock = DateTime.Now.Hour.ToString();
                sevk.Transaction = cmbYapilanIslem.Text;
                sevk.DrCode = cmbDrKod.Text;
                sevk.Quantity = nmMiktar.Value.ToString();
                sevk.UnitPrice = txtBirimFiyat.Text;
                sevk.Secret = txtSıraNo.Text;
                sevk.TotalAmount = (Convert.ToInt32(nmMiktar.Value) * (Convert.ToInt32(txtBirimFiyat.Text))).ToString();
                SevkContract crud = new SevkContract();
                if (!crud.Discharged(sevk))
                {
                    MessageBox.Show("Lütfen Tüm alanları doldurunuz !");
                }
                MessageBox.Show("İşleminiz başarı ile gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPolikilinik.Text = null;
                txtSıraNo.Text = null;
                cmbDrKod.Text = null;
                cmbYapilanIslem.Text = null;
                nmMiktar.Value = 0;
                txtBirimFiyat.Text = null;
                lblToplamTutarSonuc.Text = sevk.TotalAmount.ToString();
            }
            #endregion
            #region Validate Control
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olunuz .. Tüm bilgiler doldurulmadığı taktirde işlemi gerçekleştiremeyeceksiniz .. ",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            #endregion
        }
        #endregion

        #region Kaydetme işlemi yapılmadan önce boş kontrolü (validate) yapılmaktadır .. 
        public bool SaveEmptyControl()
        {
            bool returnObject = false;
            if (String.IsNullOrEmpty(txtDosyaNumara.Text) ||
               String.IsNullOrEmpty(txtSevk.Text) ||
               String.IsNullOrEmpty(cmbOncekiIslem.Text) ||
               String.IsNullOrEmpty(txtKAdi.Text) ||
               String.IsNullOrEmpty(txtTcNo.Text) ||
               String.IsNullOrEmpty(txtDogumYer.Text) ||
               cmbPolikilinik.SelectedIndex == 0 ||
               String.IsNullOrEmpty(txtSıraNo.Text) ||
               cmbYapilanIslem.SelectedIndex == 0 ||
               cmbDrKod.SelectedIndex == -0 ||
               String.IsNullOrEmpty(nmMiktar.Value.ToString()) ||
               String.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                returnObject = true;
            }
            return returnObject;
        }
        #endregion

        #region DatatGridde sevk tablosundaki bilgilerin çekilmesi
        public void DataGridLoadData()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog() { Width = 800, Height = 600 };

            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }
        #endregion

        #region Combobox lar dolduruluyor
        public void LoadToCombobox()
        {
            #region Comboboxlardaki ilk indislerin Seçiniz olarak dolu gelmesi ayarlanmıştır .. 
            cmbPolikilinik.Items.Insert(0, "Seçiniz");
            cmbYapilanIslem.Items.Insert(0, "Seçiniz");
            cmbDrKod.Items.Insert(0, "Seçiniz");
            cmbOncekiIslem.Items.Insert(0, "Seçiniz");
            cmbPolikilinik.SelectedIndex = 0;
            cmbYapilanIslem.SelectedIndex = 0;
            cmbDrKod.SelectedIndex = 0;
            cmbOncekiIslem.SelectedIndex = 0;
            #endregion

            #region Poliklinik comboboxı dolduruluyor .. 
            PoliklinikContract poliklinikContract = new PoliklinikContract();
            List<poliklinik> polikliniks = new List<poliklinik>();
            polikliniks = poliklinikContract.GetPoliklinik(null);
            foreach (var pol in polikliniks)
                cmbPolikilinik.Items.Add(pol.PolyclinicName);
            #endregion

            #region Dr.Kodu comboboxı dolduruluyor .. 
            HastaContract hastaContract = new HastaContract();
            List<hasta> patients = new List<hasta>();
            patients = hastaContract.GetPatient(null);
            foreach (var patient in patients)
                cmbDrKod.Items.Add(patient.FileNumber);
            #endregion

            #region Önceki İşlemler comboboxı dolduruluyor ..
            SevkContract sevkContract = new SevkContract();
            List<sevk> sevks = new List<sevk>();
            sevks = sevkContract.SelectDischarged(txtDosyaNumara.Text, cmbOncekiIslem.SelectedItem.ToString());
            foreach (var sevk in sevks)
                cmbOncekiIslem.Items.Add(sevk.ShipmentDate);
            #endregion
        }
        #endregion

        #region dataGride tablodaki veriler çekiliyor .. 
        public void LoadToDataGridData()
        {
            List<sevk> dischargedList = new List<sevk>();
            SevkContract crud = new SevkContract();
            dischargedList = crud.SelectDischarged(txtDosyaNumara.Text, cmbOncekiIslem.Text);
            int number = 0;
            foreach (var item in dischargedList)
            {
                dtgYapilanIslemSonuc.Rows.Add();
                dtgYapilanIslemSonuc.Rows[number].Cells[0].Value = item.Polyclinic;
                dtgYapilanIslemSonuc.Rows[number].Cells[1].Value = item.Secret;
                dtgYapilanIslemSonuc.Rows[number].Cells[2].Value = item.Clock;
                dtgYapilanIslemSonuc.Rows[number].Cells[3].Value = item.Transaction;
                dtgYapilanIslemSonuc.Rows[number].Cells[4].Value = item.DrCode;
                dtgYapilanIslemSonuc.Rows[number].Cells[5].Value = item.Quantity;
                dtgYapilanIslemSonuc.Rows[number].Cells[6].Value = item.UnitPrice;
                number++;
            }
        }
        #endregion

        #region DataGride tablodaki veriler sevk tarihine göre çekiliyor .. 
        public void LoadDoDataGridToShipmentDate()
        {
            List<sevk> shipmentDate = new List<sevk>();
            SevkContract contract = new SevkContract();
            shipmentDate = contract.SelectShipmentDateTo(cmbOncekiIslem.Text);
            int number = 0;
            foreach (var item in shipmentDate)
            {
                dtgYapilanIslemSonuc.Rows.Add();
                dtgYapilanIslemSonuc.Rows[number].Cells[0].Value = item.Polyclinic;
                dtgYapilanIslemSonuc.Rows[number].Cells[1].Value = item.Secret;
                dtgYapilanIslemSonuc.Rows[number].Cells[2].Value = item.Clock;
                dtgYapilanIslemSonuc.Rows[number].Cells[3].Value = item.Transaction;
                dtgYapilanIslemSonuc.Rows[number].Cells[4].Value = item.DrCode;
                dtgYapilanIslemSonuc.Rows[number].Cells[5].Value = item.Quantity;
                dtgYapilanIslemSonuc.Rows[number].Cells[6].Value = item.UnitPrice;
                number++;
            }
        }
        #endregion

        #region Sıra textboxı na değer girişi yapılmaktadır. SP den gelen değere göre otomatik sıra atanmaktadır . 
        public void GetQueue()
        {
            SevkContract contract = new SevkContract();
            DataTable dataSevk = contract.GetFindQueue(cmbPolikilinik.SelectedItem.ToString(), cmbPolikilinik.SelectedIndex + 1);

            foreach (DataRow item in dataSevk.Rows)
            {
                txtSıraNo.Text = item[0].ToString();
            }

        }
        #endregion

        #region CalculatedToTalAmount() --> Toplam tutar hesaplanıyor .. 
        private void CalculatedToTalAmount()
        {
            decimal total = 0;
            for (int i = 0; i < dtgYapilanIslemSonuc.Rows.Count; i++)
            {
                total += Convert.ToInt32(dtgYapilanIslemSonuc.Rows[i].Cells["TotalAmount"].Value);
            }
            lblToplamTutarSonuc.Text = string.Format("{0} TL ", Convert.ToDecimal(total));
        }
        #endregion

        #region DataGridHide() --> gizleniyor
        private void DataGridHide()
        {
            if (dtgYapilanIslemSonuc.RowCount > 0)
            {
                dtgYapilanIslemSonuc.Columns[0].Visible = false;
                dtgYapilanIslemSonuc.AllowUserToAddRows = false;
            }
        }
        #endregion

        #endregion
    }
}