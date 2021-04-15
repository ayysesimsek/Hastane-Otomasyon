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
    public partial class UIUser : Form
    {
        #region Public Members
        public Button updatedInsertedButton;
        public TextBox DoreadOnly;
        #endregion

        #region CONSTRUCTOR
        public UIUser()
        {
            InitializeComponent();
        }
        #endregion

        #region EVEENT / CLICK

        /// <summary>
        /// Load kısım. Ekran ilk açılırken butonun duruma göre isminin değişmesi ayarlanmaktadır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIUser_Load(object sender, EventArgs e)
        {
            updatedInsertedButton = btnGüncelle;
            DoreadOnly = txtKullaniciKod;
        }

        /// <summary>
        /// Dışarıdan bu ekran çağrılırken ilgili code numarası çağrıldığı zaman
        /// alanların o code numarasına ait olan kişinin bilgileri ile doldurulması işlemi ger.ekleşmektedir .. 
        /// </summary>
        /// <param name="code"></param>
        public void LoadDataInUserInformation(string code)
        {
            List<kullanici> users = new List<kullanici>();
            KullaniciContract crud = new KullaniciContract();
            users = crud.GetUser(code);
            foreach (var item in users)
            {
                txtKullaniciKod.Text = item.Code;
                txtTcNo.Text = item.TCKN;
                txtDogumYeri.Text = item.PlateOfBirthh;
                txtBabaAdi.Text = item.FatherName;
                txtAnneAdi.Text = item.MotherName;
                txtTelNo.Text = item.MobilePhone;
                cmbUnvan.Text = item.Title;
                txtAd.Text = item.Name;
                txtSoyad.Text = item.SurName;
                txtMaas.Text = item.Salary;
                //dtIseBaslama.Value = item.StartWork;
                //dtDogumTarih.Value = item.DateOfBirth;
                cmbCinsiyet.Text = item.Gender;
                cmbKanGrubu.Text = item.BloodGroup;
                cmbMedeniHal.Text = item.MarialStatus;
                if (item.Authority == "var")
                    chkYetkiliKullanici.Checked = true;
                else
                    chkYetkiliKullanici.Checked = false;
                txtAdres.Text = item.Address;
                txtKullaniciAdi.Text = item.UserName;
                txtSifre.Text = item.Password;
            }
        }

        /// <summary>
        /// Güncelle butonua tıklanıldığında çağrılan ekran tarafından butodaki isim değişiyor.
        /// Buton kaydet ise kaydetme işlemleri
        /// Buton güncellle ise güncelleme işlemleri gerçekleşmektedir .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            AddOrUpdateByStataus();
        }

        /// <summary>
        /// Sil (Delete) butonuna basıldığında ilgili kullanıcının veritabanından silinmesi işlemi gerçekleşmektedir ... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz ?",
                                                  "Uyarı",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KullaniciContract crud = new KullaniciContract();
                crud.DeletedUser(txtKullaniciKod.Text);
                MessageBox.Show("Başarı ile silme işlemi gerçekleşmiştir. Silinen Kayıt : " +
                                txtKullaniciKod.Text,
                                "Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                UIUserIdentification user = new UIUserIdentification();
                user.LoadUser();
                this.Close();
            }

        }

        /// <summary>
        /// Temizle (Clear) butonuna basıldğında dolu olan alanların boşaltılması sağlanmaktadır ... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is ComboBox)
                    ((ComboBox)item).Text = "";
                dtDogumTarih.Value = System.DateTime.Now;
                dtIseBaslama.Value = System.DateTime.Now;
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
            }
        }

        #region RAKAM / TEX GİREMEME ... 

        /// <summary>
        /// --> txtKullaniciKod <--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKullaniciKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        /// <summary>
        /// --> txtTcNo <--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// --> txtDogumYeri <--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDogumYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        /// <summary>
        /// --> txtTelNo <--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        /// <summary>
        /// --> cmbUnvan <--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUnvan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        /// <summary>
        /// --> txtMaas <--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        /// <summary>
        /// "Çıkış yapmak ister misinz ?" Butonu işlemleri yapılmaktadır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?",
                                "Bildiri",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Duruma göre Insert / Update işlemi yapılmaktadır .. .
        /// </summary>
        public void AddOrUpdateByStataus()
        {
            #region Buton = "Kaydet" ise -->
            if (btnGüncelle.Text.Equals("Kaydet"))
            {
                #region Eklenecek veriler kullanici tablosundaki ilgili alanlara aktarılıyor ..
                kullanici user = new kullanici();
                user.Code = txtKullaniciKod.Text;
                user.TCKN = txtTcNo.Text;
                user.PlateOfBirthh = txtDogumYeri.Text;
                user.FatherName = txtBabaAdi.Text;
                user.MotherName = txtAnneAdi.Text;
                user.Title = cmbUnvan.Text;
                user.Name = txtAd.Text;
                user.MobilePhone = txtTelNo.Text;
                user.SurName = txtSoyad.Text;
                user.Salary = txtMaas.Text;
                user.HomePhone = txtGsm.Text;
                user.StartWork = Convert.ToDateTime(dtIseBaslama.Value.ToShortDateString());
                user.DateOfBirth = Convert.ToDateTime(dtDogumTarih.Value.ToShortDateString());
                user.Gender = cmbCinsiyet.Text;
                user.BloodGroup = cmbKanGrubu.Text;
                user.MarialStatus = cmbMedeniHal.Text;
                user.Address = txtAdres.Text;
                user.UserName = txtKullaniciAdi.Text;
                user.Password = txtSifre.Text;
                if (chkYetkiliKullanici.Checked)
                    user.Authority = "var";
                else
                    user.Authority = "yok";
                KullaniciContract crud = new KullaniciContract();
                if (!crud.InsertUserTable(user))
                    MessageBox.Show("Lütfen Tüm alanları doldurunuz !");

                UIUserIdentification userIden = new UIUserIdentification();
                userIden.LoadUser();
                this.Close();
                MessageBox.Show("Kayıt işlemi gerçekleşmiştir. Kaydedilen Kayıt : " + txtKullaniciKod.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            #endregion
            #region Buton = "Güncelle" ise -->
            else
            {
                #region Güncellenecek bilgiler değişiklik sonucunda kullanici tablosundakii ilgili alanlara aktarılmaktadır .. 
                DialogResult result = MessageBox.Show("Güncellemek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    kullanici user = new kullanici();
                    user.Code = txtKullaniciKod.Text;
                    user.TCKN = txtTcNo.Text;
                    user.PlateOfBirthh = txtDogumYeri.Text;
                    user.FatherName = txtBabaAdi.Text;
                    user.MotherName = txtAnneAdi.Text;
                    user.Title = cmbUnvan.Text;
                    user.Name = txtAd.Text;
                    user.MobilePhone = txtTelNo.Text;
                    user.SurName = txtSoyad.Text;
                    user.Salary = txtMaas.Text;
                    user.HomePhone = txtGsm.Text;
                    user.StartWork = Convert.ToDateTime(dtIseBaslama.Value.ToShortDateString());
                    user.DateOfBirth = Convert.ToDateTime(dtDogumTarih.Value.ToShortDateString());
                    user.Gender = cmbCinsiyet.Text;
                    user.BloodGroup = cmbKanGrubu.Text;
                    user.MarialStatus = cmbMedeniHal.Text;
                    user.Address = txtAdres.Text;
                    user.UserName = txtKullaniciAdi.Text;
                    user.Password = txtSifre.Text;
                    if (chkYetkiliKullanici.Checked)
                        user.Authority = "var";
                    else
                        user.Authority = "yok";
                    KullaniciContract crud = new KullaniciContract();
                    if (!crud.UpdateUserTable(user))
                        MessageBox.Show("Lütfen Tüm alanları doldurunuz !");
                    MessageBox.Show("Güncelleme işlemi gerçekleşmiştir. Güncellenen Kayıt : " + txtKullaniciKod.Text,
                                    "Bilgi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    UIUserIdentification userIden = new UIUserIdentification();
                    userIden.LoadUser();
                    this.Close();
                }
                #endregion
            }
            #endregion
        }

        #endregion
    }
}
