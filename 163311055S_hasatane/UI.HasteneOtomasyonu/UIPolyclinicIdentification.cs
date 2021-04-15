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
    public partial class UIPolyclinicIdentification : Form
    {
        #region CONSTRUCTOR
        public UIPolyclinicIdentification()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT / CLICK

        /// <summary>
        /// Form yüklenirken ... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIPolyclinicIdentification_Load(object sender, EventArgs e)
        {
            LoadToPolyclicnic();
        }

        #region Combobox içerisinden seçilen işlemde entera basıldığında Poliklinik ekranına geçiş sağlanmaktadır .. 
        UIPolyclinic pol = new UIPolyclinic();
        private void cmbPoliklinik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter' a basıldığında buraya girer.
                pol.Name = cmbPoliklinik.Text;
                pol.MdiParent = this.MdiParent;
                pol.Show();
                pol.Location = new Point(250, 120);
            }
        }
        #endregion

        #endregion

        #region METHOD

        /// <summary>
        /// LoadToPolyclicnic() --> Form yüklendiğinde poliklinik tablosundaki veriler combobox içerisine doldurulmaktadır .. 
        /// </summary>
        public void LoadToPolyclicnic()
        {
            PoliklinikContract crud = new PoliklinikContract();
            List<poliklinik> poliklinikler = crud.GetPoliklinik(null);
            foreach (var item in poliklinikler)
            {
                cmbPoliklinik.Items.Add(item.PolyclinicName);
            }
        }
   
        #endregion
    }
}
