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
    public partial class UIPolyclinic : Form
    {
        #region Public Members
        public object CRUDTransaction { get; private set; }
        public string Name;
        #endregion

        #region CONSTRUCTOR
        public UIPolyclinic()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT / CLICK

        /// <summary>
        /// Load Ana form yüklenirken .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIPolyclinic_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       
        /// <summary>
        /// Ekleme butonuna tıklanıldığında poliklinik tablosuna ekleme işlemi gerçekleşmektedir ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            poliklinik pol = new poliklinik();
            PoliklinikContract contract = new PoliklinikContract();

            #region Eklenecek veriler atanıyor ..
            pol.PolyclinicName = txtPoliklnik.Text;
            pol.Description = txtAciklama.Text;
            if (checkBoxActive.Checked)
                pol.Status = "1";
            else
                pol.Status = "0";
            #endregion
            
            if (!contract.InsertPolyclinic(pol))
            {
                MessageBox.Show("Tüm alanları doldurmalısınız !! ");
            }
            else
            {
                MessageBox.Show("İşleminiz başarı ile gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkBoxActive.Checked)
                    checkBoxActive.Checked = false;
                LoadData();
                txtPoliklnik.Text = null;
                txtAciklama.Text = null;
            }
        }

        /// <summary>
        /// Sil butonuna tıklanıldığında seçili olan işlemin silinmesi gerçekleşmektedir .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            poliklinik selectedPK = (poliklinik)dataGridView1.CurrentRow.DataBoundItem;
            if (selectedPK == null)
            {
                MessageBox.Show("Poliklinik seçiniz.");
                return;
            }

        }

        /// <summary>
        /// Çıkış butonuna basıldığğında gerçekleşecek olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Sil butonuna tıkladığında gerçekleşecek olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            PoliklinikContract crud = new PoliklinikContract();
            poliklinik deleted = new poliklinik();
            deleted = (poliklinik)dataGridView1.CurrentRow.DataBoundItem;
            if (deleted == null)
            {
                MessageBox.Show("Poliklinik seçiniz.");
                return;
            }

            int ID = deleted.PoliklinikID;
            if (crud.DeletePolyclinic(ID))
            {
                MessageBox.Show(deleted.PolyclinicName + " başarıyla silinmiştir. ");
                LoadData();
            }
        }

        /// <summary>
        /// Güncelle butonuna tıklanıldığında gerçekleşecek olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek istediğinize emin misiniz ?",
                                "Uyarı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                poliklinik updated = (poliklinik)dataGridView1.CurrentRow.DataBoundItem;
                PoliklinikContract contract = new PoliklinikContract();

                #region Güncellenecek veriler atanıyor .. <--
                updated.PolyclinicName = txtPoliklnik.Text;
                updated.Description = txtAciklama.Text;
                if (checkBoxActive.Checked == true)
                    updated.Status = "1";
                else
                    updated.Status = "0";
                #endregion

                #region Gelen verinin null olması kontrolü yapılmaktadır .. 
                if (updated == null)
                {
                    MessageBox.Show("Poliklinik seçiniz.");
                    return;
                }
                #endregion

                #region Update successfull !!
                if (contract.UpdatePolyclinic(updated))
                {
                    MessageBox.Show(updated.PolyclinicName + " başarıyla güncellenmiştir.");
                    LoadData();
                }
                #endregion
            }
        }

        #region Rakam / Text ifade girememe kontrolleri
        private void txtPoliklnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        #endregion

        #endregion

        #region METHODS
        /// <summary>
        /// LOADDATA()
        /// DataGrid ' e poliklinik tablosundaki veriler filtrelenmektedir .. 
        /// </summary>
        public void LoadData()
        {
            PoliklinikContract crud = new PoliklinikContract();
            List<poliklinik> poliklinikler = crud.GetPoliklinik(Name);
            txtPoliklnik.Text = Name;
            dataGridView1.DataSource = poliklinikler;
        }
        #endregion
    }
}
