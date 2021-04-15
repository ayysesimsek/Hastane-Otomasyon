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
    public partial class UIContainerMainPage : Form
    {
        #region Değişkenler
        public static MenuStrip menum;
        public static ToolStripMenuItem menuReferansBilgisi;
        public static ToolStripMenuItem DoctorStatus;
        public static ToolStripMenuItem Personnelstatus;
        public static ToolStripMenuItem PoliklinikTanımlama;
        #endregion 

        #region CONSTRUCTOR
        public UIContainerMainPage()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT

        /// <summary>
        /// /Ana Form Load kısmı açılmaktadır. Burada Login ekranının pozisyonu ayarlanmıştır. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIContainerMainPage_Load(object sender, EventArgs e)
        {
            UILoginPage login = new UILoginPage(this);
            
            login.MdiParent = this;
            login.Show();
            menum = menuStrip1;
            menuStrip1.Enabled = false;
            referencesToolStripMenuItem.Visible = false;
            menuReferansBilgisi = referencesToolStripMenuItem;
            DoctorStatus = kullanıcıTanıtmaToolStripMenuItem;
            Personnelstatus = hastaToolStripMenuItem;
            PoliklinikTanımlama = polikilinikTanıtmaToolStripMenuItem;
            referencesToolStripMenuItem.Visible = false;
            login.Location = new Point(225, 145);
        }

        /// <summary>
        /// Polikinlik Tanıma ekranını açıyoruz .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hastaKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIPatientInfo patient = new UIPatientInfo();
            patient.MdiParent = this;
            patient.Show();
            patient.Location = new Point(100, 7);
        }

        /// <summary>
        /// Rapor ekranı açılıyor .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rapor1geciciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIReport report = new UIReport();
            if (Application.OpenForms["UIReport"] == null)
            {
                report.MdiParent = this;
                report.Show();
                report.Location = new Point(35, 40);
            }
            else
                MessageBox.Show("Açılan form tekrar açılmaz !! ",
                                "Bildiri",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Burada Kullanıcı tanıtma işlemlerini yapıyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["UIUserIdentification"] == null)
            {
                UIUserIdentification user = new UIUserIdentification();
                user.MdiParent = this.MdiParent;
                user.Show();
                user.Location = new Point(270, 190);
            }
            else
                MessageBox.Show("Hasta işlemleri formu zaten açılmıştır. Tekrar açmaya çalışmayınız !! ",
                                "Bildiri",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Burada logout işlemi yapabilmek için uygulamayı kapattık ve tekrar başlattık.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UILoginPage login = new UILoginPage(this);
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
                login.MdiParent = this;
                login.Show();
                login.Location = new Point(225, 145);
                menuStrip1.Enabled = false;
                referencesToolStripMenuItem.Visible = false;
            }
        }

        /// <summary>
        /// Burada Poliklinik tanıtma ekranını açıyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void polikilinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                UIPolyclinicIdentification polyclinicIdentification = new UIPolyclinicIdentification();
                polyclinicIdentification.MdiParent = this.MdiParent;
                polyclinicIdentification.Show();
                polyclinicIdentification.Location = new Point(270, 190);
        }

        #region Çıkış yapma butonu --- 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ? ",
                                "Bildiri",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        #endregion

        #region METHODS

        #region Programa giriş yaparken menülerdeki aktiflik durumu ayarlanıyor ve giren kişinin kullanıcı adı yazıyor .. 
        public void ActiveInMenu(string user)
        {
            this.menuStrip1.Enabled = true;
            this.referencesToolStripMenuItem.Visible = true;
            lblInfo.Text = " --> SOHATS <-- Programa giriş yapan --> " + user;
            lblInfo.Visible = true;
        }
        #endregion

        #endregion
    }
}
