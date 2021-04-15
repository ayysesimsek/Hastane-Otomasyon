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
    public partial class UIReport : Form
    {
        #region CONSTRUCTOR
        public UIReport()
        {
            InitializeComponent();
        }
        #endregion

        #region CLICK / EVENT

        /// <summary>
        /// Yazdır butonuna tıklanıldığında gerçekleşecek olaylar .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog onizleme = new PrintPreviewDialog();
                onizleme.Document = printDocument1;
                onizleme.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Programda Beklenmedik Hata Oluştu ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }

        /// <summary>
        /// PrintDocument_PrintPage -- 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 40, dataGridView.Width, dataGridView.Height));
            e.Graphics.DrawString(" Başlangıç Tarihi : " + dateTimePickerBegin.ToString().ToUpper() +
                                  " Bitiş Tarihi : " + dateTimePickerEnd.ToString().ToUpper(),
                                  new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular),
                                  new SolidBrush(Color.Black),
                                  new Point(10, 10));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        /// <summary>
        /// Yazdırma işleminden sonra mesaj bildirimi .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("Yazdırma işlemi tamamlandı . ");
        }

        /// <summary>
        /// Temizle butonuna tıklanıldığında gerçekleşecek olaylar .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "";
            foreach (Control item in this.Controls)
            {
                if (item is DateTimePicker)
                    item.Text = DateTime.Now.ToShortDateString();
                if (rbTaburcu.Checked)
                    rbTaburcu.Checked = false;
                if (rbTaburcuDegil.Checked)
                    rbTaburcuDegil.Checked = false;
                if (rbHepsi.Checked)
                    rbHepsi.Checked = false;
            }
        }

        /// <summary>
        /// Çıkış yap butonuna tıklanıldığında gerçekleşecek olay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ? ",
                                "Bildiri",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Sorgula butonuna tıklanıldığında gerçekeleşecek olaylar yazılmaktadır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            List<sevk> dischargedList = new List<sevk>();
            List<sevk> taburcuList = new List<sevk>();
            SevkContract contract = new SevkContract();
            dischargedList = contract.SelectDischarged("", "");
            int number = 0;

            #region Değerler alınıyor .. 
            string beginDate = dateTimePickerBegin.Value.ToShortDateString();
            string endDate = dateTimePickerEnd.Value.ToShortDateString();

            if (rbTaburcu.Checked)
                taburcuList = contract.GetDischargedDateTimeTo("Oldu");
            if (rbTaburcuDegil.Checked)
                taburcuList = contract.GetDischargedDateTimeTo("Olmadı");
            #endregion
            #region Empty Control
            if (rbHepsi.Checked == false && rbTaburcu.Checked == false && rbTaburcuDegil.Checked == false)
            {
                MessageBox.Show("Sorgulama Yapabilmek İçin Kriterlerden (RadioButton) 'lardan Birini Seçmeniz Gerek !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            #endregion
            #region --> Taburcu RadioButtona tıklanıldığında <--
            if (rbTaburcu.Checked)
            {
                dtgYapilanIslemSonuc.Rows.Clear();
                foreach (var item in taburcuList)
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
            #region --> Taburcu Değil RadioButtona tıklanıldığında <--
            else if (rbTaburcuDegil.Checked)
            {
                dtgYapilanIslemSonuc.Rows.Clear();
                foreach (var item in taburcuList)
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
            #region --> Hepsi RadioButtona tıklanıldığında <--
            else if (rbHepsi.Checked)
            {
                dtgYapilanIslemSonuc.Rows.Clear();
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

            number = 0;
        }

        /// <summary>
        /// Rapor ekranı Load kısmı. Sayfa yüklenirken <
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UIReport_Load(object sender, EventArgs e)
        {
            rbTaburcu.Checked = false;
            rbTaburcuDegil.Checked = false;
            rbHepsi.Checked = false;
        }

        #endregion
    }
}
