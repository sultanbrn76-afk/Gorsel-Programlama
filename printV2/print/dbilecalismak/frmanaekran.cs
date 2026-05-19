using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbilecalismak
{
    public partial class frmanaekran : Form
    {
        public frmanaekran()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void frmanaekran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void productsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ToolStripleridoldur();
            sutunfiltredoldur();
        }

        private void sutunfiltredoldur()
        {
            var sutunlar = productsDataGridView.Columns;
            foreach (DataGridViewColumn sutun in sutunlar)
            {
                toolStripComboBox.Items.Add(sutun.DataPropertyName);
            }
        }

        private void ToolStripleridoldur()
        {
            string toplamStok = northwindDataSet.Products.Compute("SUM(UnitsInStock)", "true").ToString();

            toolStripLabel.Text = $"toplam stok:{toplamStok:0,00}";

            int satirsayisi = productsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible);

            toolStripLabel1.Text = $"Toplam satır:{satirsayisi}";
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sutunIsmi = (sender as ToolStripComboBox).Text;
            toolStripComboBoxfilter.Text = string.Empty;
            toolStripComboBoxfilter.Items.Clear();

            var sutunVerileri = northwindDataSet.Products.Columns[sutunIsmi].Table.Rows;

            foreach(DataRow satır in sutunVerileri)
            {
                string veri = satır[sutunIsmi].ToString();
                if(!toolStripComboBoxfilter.Items.Contains(veri))
                {
                    toolStripComboBoxfilter.Items.Add(veri);
                }
            }

        }

        bool tiklandimi = false;
        private void ToolStripButtonfiltrele_Click(object sender, EventArgs e)
        {
            var buton = (sender as ToolStripButton);
            tiklandimi = !tiklandimi;
            if(!tiklandimi)
            {
                toolStripComboBoxfilter.Text = "filtrele";
                northwindDataSet.Products.DefaultView.RowFilter = null;
                return;
            }
            buton.Text = "tümünü göster";
            string sutunbilgisi = toolStripComboBox.Text;
            string filtreicerik= toolStripComboBoxfilter.Text;
            try
            {
                northwindDataSet.Products.DefaultView.RowFilter = $"{sutunbilgisi}LIKE '%{filtreicerik}%'";
            }
            catch (Exception)
            {

                MessageBox.Show("tip uyuşmazlığı");
            }
            finally
            {
                productsDataGridView.DataSource = northwindDataSet.Products.DefaultView;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            var cevap = printDialog.ShowDialog();
            try
            {
                if (cevap == DialogResult.OK)
                {
                    printDocument.Print();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("yazıcıda sorun var");
            }
            

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap=new Bitmap(productsDataGridView.Width, productsDataGridView.Height);
            Rectangle rectangle= new Rectangle(0,0, bitmap.Width, bitmap.Height);

            productsDataGridView.DrawToBitmap(bitmap, rectangle);
            e.Graphics.DrawImage(bitmap, rectangle);
        }

        private void menu(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var cevap = MessageBox.Show(
                "çıkmak istediğinize emin misiniz?",
                "çıkalım mı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

