using Business.SOHATS.HastaneOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Types.HastaneOtomasyonu;
using Types.HastaneOtomasyonu.Entitiy;

namespace UI.HasteneOtomasyonu
{
    public partial class UILoginPage : Form
    {
        #region Değişkenler
        UIContainerMainPage main;
        public bool isVisibleClosing = false;
        List<String> ts = new List<String>();

        #endregion

        #region CONSTRUCTOR
        public UILoginPage(UIContainerMainPage main)
        {
            InitializeComponent();
            this.main = main;
        }
        #endregion

        #region EVENTLER

        #region Giriş butonuna tıklanıldığında login işlemi yapılmaktadır. 
        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            if (EmptyControl())
            {
                List<kullanici> users = new List<kullanici>();
                KullaniciContract database = new KullaniciContract();
                string userName = txtUsername.Text;
                users = database.GetUser(null);

                #region username - password alanı doğru ise <--
                int IsThere = users.Where(x => (x.UserName.Equals(txtUsername.Text)) && (x.Password.Equals(txtPassword.Text))).Count();
                if (IsThere > 0)
                {
                    int IsDo = users.Where(k => (k.UserName.Equals(txtUsername.Text)) && (k.Password.Equals(txtPassword.Text)) && (k.Authority.Equals("var"))).Count();
                    if (IsDo > 0)
                    {
                        #region Ana form yüklenirken hangi menülerin gözüküp gözükmeyeceği ayarlanıyor .. 
                        this.Close();
                        UIContainerMainPage.menum.Visible = true;
                        UIContainerMainPage.menuReferansBilgisi.Visible = true;
                        if (cmbPozisyon.SelectedIndex == 0)
                        {
                            UIContainerMainPage.DoctorStatus.Visible = false;
                            main.ActiveInMenu(userName);
                        }
                        if (cmbPozisyon.SelectedIndex == 1)
                        {
                            UIContainerMainPage.Personnelstatus.Visible = false;
                            UIContainerMainPage.DoctorStatus.Visible = true;
                            UIContainerMainPage.PoliklinikTanımlama.Visible = false;
                            main.ActiveInMenu(userName);
                        }
                        #endregion
                    }
                    else
                    {
                        this.Close();
                        UIContainerMainPage.menum.Visible = true;
                        UIContainerMainPage.menuReferansBilgisi.Visible = false;
                    }
                }
                #endregion
                else
                    MessageBox.Show("Yanlış kullanıcı adı ve/veya şifre",
                                    "Uyarı",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Çıkış butonuna basıldığında gerçekleşecek işlemler yapılmaktadır. 
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz ? ",
                                                 "Bildiri",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Temizle butonuna tıklanıldığında gerçekleşecek olaylar
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        #endregion

        #region Password in Show / Hide
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion

        #region Kayan Yazı ile başlık ayarlanıyor .. 
        private void UILoginPage_Load(object sender, EventArgs e)
        {
            this.Text = " --> SAĞLIK OCAĞI HASTA TAKİP SİSTEMİNE HOŞGELDİNİZ <-- ";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }
        #endregion

        #endregion

        #region METHODS

        #region Boş kontrolü yapılmaktadır. 
        public bool EmptyControl()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doğru doldurduğunuza emin olunuz. ! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cmbPozisyon.Text))
            {
                MessageBox.Show("Lütfen pozisyonunuzu seçiniz ! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        #endregion

        #endregion
    }
}
