using Business.SOHATS.HastaneOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Types.HastaneOtomasyonu.Entitiy;

namespace UI.HasteneOtomasyonu
{
    public partial class UIDischarged : Form
    {
        #region Public Members
        private hasta selectedPatient;
        int processId = 0;
        #endregion

        #region CONSTRUCTOR
        public UIDischarged()
        {
            InitializeComponent();
        }

        public UIDischarged(hasta pt, string tutar, int processId)
        {
            InitializeComponent();
            this.selectedPatient = pt;
            txtToplamTutar.Text = tutar;
            this.processId = processId;
        }
        #endregion

        #region EVENT / CLICK

        /// <summary>
        /// Kaydet butonuna basıldığında girilen bilgilere göre hasta taburcu edilmiş oldu .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbTaburcu_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmptyControl())
                {
                    CikisContract contract = new CikisContract();
                    cikis exit = new cikis();
                    List<cikis> CikisList = new List<cikis>();
                    CikisList = contract.GetPatient(txtDosyaNo.Text);

                    #region Taburcu edilen hasta kontrolü yapılmaktadır .. 
                    foreach (var item in CikisList)
                    {
                        if (item.FileNumber.ToString() == txtDosyaNo.Text)
                        {
                            MessageBox.Show("Taburcu Edilmiş Hastayı Tekrar Taburcu Edemezsiniz !!!",
                                            "Bilgi",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    #endregion

                    #region Taburcu işlemi gerçekleşmektedir. --> cikis tablosuna bilgiler eklenmektedir .. <--

                    exit.FileNumber = txtDosyaNo.Text;
                    exit.ShipmentDate = dtSevkTarihi.Value.ToShortDateString();
                    exit.OutputClock = (DateTime)dtCikisTarihi.Value;
                    exit.Pay = cmbOdemeSekli.Text;
                    exit.TotalAmount = txtToplamTutar.Text;
                    if (!contract.InsertExitDischarged(exit))
                    {
                        MessageBox.Show("Lütfen Tüm alanları doldurunuz !");
                    }
                    else
                    {
                        foreach (Control item in this.Controls)
                        {
                            if (item is TextBox)
                                ((TextBox)item).Text = "";
                            if (item is ComboBox)
                                ((ComboBox)item).Text = "";
                        }
                        MessageBox.Show(txtDosyaNo.Text + " dosya numaralı hasta taburcu edilmiştir .. ");
                    }

                    #endregion
                }               
            }
            catch(Exception error)
            {
                MessageBox.Show("Programda Beklenmedik Hata Oluştu " + error.Message,
                                "UYARI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                return;
            }
        }

        /// <summary>
        /// Vazgeç butonundaki işlemler yapılmaktadır. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Form Load sayfa yüklenirken <
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIDischarged_Load(object sender, EventArgs e)
        {
            dtCikisTarihi.Value = DateTime.Now.Date;
            cmbOdemeSekli.DataSource = Enum.GetValues(typeof(PaymentType));
            cmbOdemeSekli.SelectedIndex = -1;
        }

        /// <summary>
        /// Sevk Tarihi seçilirken kontroller yapılmaktadır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtSevkTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtSevkTarihi.Value > DateTime.Today.Date)
            {
                MessageBox.Show("Sevk Tarihi Bugununden Ileri Bir Tarih Olamaz !!!",
                                "UYARI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                return;
            }
        }

        #region RAKAM / TEXT girilememe kontrolleri yapılmaktadır .. 
        private void txtToplamTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #endregion

        #region METHODS

        #region Dosya numarası gelen bilgideki hastanın bilgilerinin doldurulması sağlanıyor.
        public bool FillToArea(string fileNumber)
        {
            List<cikis> patient = new List<cikis>();
            CikisContract crud = new CikisContract();
            patient = crud.GetPatient(fileNumber);

            if (patient.Count > 0)
            {
                foreach (var item in patient)
                {
                    txtDosyaNo.Text = item.FileNumber;
                    dtSevkTarihi.Text = item.ShipmentDate;
                    dtCikisTarihi.Value = (DateTime)item.OutputClock;
                    cmbOdemeSekli.Text = item.Pay;
                    txtToplamTutar.Text = item.TotalAmount;
                    dtSevkTarihi.Enabled = false;
                    dtCikisTarihi.Enabled = false;
                    txtDosyaNo.Enabled = false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Taburcu kayıt işlemlerinin gerçekleşebilmesi için boş kontrolleri yapılmaktadır ..
        public bool EmptyControl()
        {
            bool returnObject = true;
            if (string.IsNullOrEmpty(txtToplamTutar.Text) || string.IsNullOrEmpty(cmbOdemeSekli.Text))
            {
                MessageBox.Show("Lütfen zorunlu alanları boş bırakmayınız !!!",
                                "Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                returnObject = false;
            }
            else if (dtCikisTarihi.Value.Date < dtSevkTarihi.Value.Date)
            {
                MessageBox.Show("Sevk Tarihi Çıkış Tarihinden ileri Bir Tarih Olamaz Lütfen doğru bir tarih giriniz  !!!",
                                "Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                dtCikisTarihi.Value = DateTime.Now;
                returnObject = false;
            }
            return returnObject;
        }
        #endregion

        #endregion
    }
}
