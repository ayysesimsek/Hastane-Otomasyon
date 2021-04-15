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
using Types.HastaneOtomasyonu;
using Types.HastaneOtomasyonu.Entitiy;

namespace UI.HasteneOtomasyonu
{
    public partial class UIPatientProcess : Form
    {
        #region CONSTRUCTOR
        public UIPatientProcess()
        {
            InitializeComponent();
        }
        #endregion

        #region METHOD

        /// <summary>
        /// Dosya numarası gelen bilgideki hastanın bilgilerinin doldurulması sağlanıyor.
        /// </summary>
        /// <param name="fileNumber"></param>
        public bool FillToArea(string fileNumber)
        {
            List<hasta> patient = new List<hasta>();
            HastaContract crud = new HastaContract();
            patient = crud.GetPatient(fileNumber);

            if (patient.Count > 0)
            {
                foreach (var item in patient)
                {
                    txtTcNo.Text = item.TCKN;
                    txtDosyaNo.Text = item.FileNumber;
                    txtAd.Text = item.Name;
                    txtSoyad.Text = item.SurName;
                    txtDogumYer.Text = item.PlaceOfBirth;
                    dtDogumTarih.Value = item.DateOfBirth;
                    txtBabaAd.Text = item.FatherName;
                    txtAnneAd.Text = item.MotherName;
                    cmbCinsiyet.Text = item.Gender;
                    cmbKanGrubu.Text = item.BloodGroup;
                    txtAdres.Text = item.Address;
                    txtTelNo.Text = item.MobilePhone;
                    txtKurumSicilNo.Text = item.FoundationRegistrationNumber;
                    txtKurumAd.Text = item.FoundationName;
                    txtYakınTel.Text = item.CloseMobilePhone;
                    txtKurumSicilNo2.Text = item.CloseFoundationRegistrationNumber;
                    txtKurumAd2.Text = item.CloseFoundationName;
                }
                return true;
            }
            else
                return false;
        }

        #region Hasta işlemleri bilgilerini veritabanına ekleme işlemleri gerçekleşmektedir.
        public void InsertPatientProcessMethod()
        {
            #region Boş kontrolü yapılmaktadır ..
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text == string.Empty)
                    {
                        if (((TextBox)item).Text == string.Empty)
                        {
                            MessageBox.Show("Gerekli alanları doldurunuz.");
                            return;
                        }
                    }
                }
                if (item is ComboBox)
                {
                    if (((ComboBox)item).Text == string.Empty)
                    {
                        if (((TextBox)item).Text == string.Empty)
                        {
                            MessageBox.Show("Gerekli alanları doldurunuz.");
                            return;
                        }
                    }
                }
            }
            #endregion
            #region Kayıt işlemi gerçekleşmektedir .. 
            try
            {
                hasta patient = new hasta();
                patient.TCKN = txtTcNo.Text;
                patient.FileNumber = txtDosyaNo.Text;
                patient.Name = txtAd.Text;
                patient.SurName = txtSoyad.Text;
                patient.PlaceOfBirth = txtDogumYer.Text;
                patient.DateOfBirth = dtDogumTarih.Value;
                patient.FatherName = txtBabaAd.Text;
                patient.MotherName = txtAnneAd.Text;
                patient.Gender = cmbCinsiyet.Text;
                patient.BloodGroup = cmbKanGrubu.Text;
                patient.Address = txtAdres.Text;
                patient.MobilePhone = txtTelNo.Text;
                patient.FoundationRegistrationNumber = txtKurumSicilNo.Text;
                patient.FoundationName = txtKurumAd.Text;
                patient.CloseMobilePhone = txtYakınTel.Text;
                patient.CloseFoundationRegistrationNumber = txtKurumSicilNo2.Text;
                patient.CloseFoundationName = txtKurumAd2.Text;
                HastaContract crud = new HastaContract();
                if (!crud.InsertPatientProcess(patient))
                {
                    MessageBox.Show("Lütfen Tüm alanları doldurunuz !");
                }
                MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.. ", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            #endregion
        }
        #endregion

        #endregion

        #region EVENT - CLICK

        /// <summary>
        /// Kaydet butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            InsertPatientProcessMethod();
        }

        /// <summary>
        /// Çıkış yap butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ? ",
                                "Bildiri",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        /// <summary>
        /// Yeni butonu oluşturulmuştur. Tekrardan boş bir forma kayıt eklemek için tıklanılır... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeni_Click(object sender, EventArgs e)
        {
            UIPatientProcess goPatient = new UIPatientProcess();
            this.Hide();
            goPatient.MdiParent = this.MdiParent;
            goPatient.Show();
            goPatient.Location = new Point(1000, 55);
        }

        /// <summary>
        /// Temizle butonuna basıldığında dolu olan alanlar temizlenmektedir ... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is ComboBox)
                    ((ComboBox)item).Text = "";
            }
        }

        #region Rakam Text girememe durum kontrolleri 
        private void txtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKurumSicilNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYakınTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKurumSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }
        #endregion

        #endregion
    }
}
