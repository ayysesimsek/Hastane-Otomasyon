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
    public partial class UIFindFile : Form
    {
        #region CONSTRUCTOR
        public UIFindFile()
        {
            InitializeComponent();
        }
        #endregion

        #region CLICK / EVENT
        /// <summary>
        /// AramaKriteri combosu --> KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAramaKriter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        /// <summary>
        /// --> Ara Butonu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            List<hasta> patientSearch = new List<hasta>();
            HastaContract crudSearch = new HastaContract();
            string information = txtBilgi.Text;
            switch (cmbAramaKriter.SelectedIndex)
            {
                #region İsme göre arama gerçekleşiyor..
                case 0:
                    patientSearch = new List<hasta>();
                    crudSearch = new HastaContract();
                    patientSearch = crudSearch.NameToGetPatient(information);
                    dtgAramaSonuc.DataSource = patientSearch;
                    break;
                #endregion

                #region TCKN'ye göre arama gerçekleşir .. 
                case 1:
                    patientSearch = new List<hasta>();
                    crudSearch = new HastaContract();
                    patientSearch = crudSearch.TCKNToGetPatient(information);
                    dtgAramaSonuc.DataSource = patientSearch;
                    break;
                #endregion

                #region Kurum Sicil No'ya göre arama gerçekleşir .. 
                case 2:
                    patientSearch = new List<hasta>();
                    crudSearch = new HastaContract();
                    patientSearch = crudSearch.FoundationRegistrationNumberToGet(information);
                    dtgAramaSonuc.DataSource = patientSearch;
                    break;
                #endregion

                #region Dosya Numarasına göre arama gerçekleşir .. 
                case 3:
                    patientSearch = new List<hasta>();
                    crudSearch = new HastaContract();
                    patientSearch = crudSearch.FileNumberToGetInformation(information);
                    dtgAramaSonuc.DataSource = patientSearch;

                    break;
                #endregion

                #region Uygun kriter girilmemişse ..
                default:
                    MessageBox.Show("Uygun kriter giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                    #endregion
            }
        }
        #endregion
    }
}
