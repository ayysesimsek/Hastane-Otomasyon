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
    public partial class UIUserIdentification : Form
    {
        #region Değişkenler
        public static string UserForCode;
        public bool newRecord = false;
        #endregion

        #region CONSTRUCTOR
        public UIUserIdentification()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT / CLICK

        /// <summary>
        /// Yeni bir kullanıcı eklemek için tanımlanan buton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (newRecord == false)
            {
                UIUser user = new UIUser();
                user.Show();
                user.MdiParent = this.MdiParent;
                user.Location = new Point(300, 15);
                user.updatedInsertedButton.Text = "Kaydet";
                newRecord = true;
            }            
        }

        /// <summary>
        /// Kullanıcı kodu combobx içerisine kullanıcı kodularıın doldurulması gerçekleşmeltedir...
        /// </summary>
        public void LoadUser()
        {
            List<kullanici> users = new List<kullanici>();
            KullaniciContract crud = new KullaniciContract();
            users = crud.GetUser(null);
            foreach (var item in users)
                cmbKullaniciKodu.Items.Add(item.Code);
        }

        /// <summary>
        /// LOAD --> Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIUserIdentification_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        /// <summary>
        /// Combo dan seçilen text neticesinde ENTER'a basarak o kullanıcının bilgilerinin dolu şekilde formda açılması
        /// işlemi gerçekleşmektedir.. Buton Texti ise duruma göre değişiklik göstermektedir .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKullaniciKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OpenUIUserForm();
            }
        }

        /// <summary>
        /// Comboboxtan seçilen değere göre güncellenecek bilgilerin olduğu kullanıcı sayfası açılmaktadır .. .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKullaniciKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenUIUserForm();
        }

        #endregion

        #region METHODS

        #region Kullanıcı Tanımlama ekranı açılıyor .. 
        public void OpenUIUserForm()
        {
            UserForCode = cmbKullaniciKodu.Text;
            UIUser user = new UIUser();
            user.MdiParent = this.MdiParent;
            user.Show();
            user.Location = new Point(200, 15);
            user.updatedInsertedButton.Text = "Güncelle";
            user.DoreadOnly.ReadOnly = true;
            user.LoadDataInUserInformation(UserForCode);
        }
        #endregion

        #endregion
    }
}
