using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Products = AlDar_1._0.Models.Products;
using Status = AlDar_1._0.Common_Class.Status;
using Excel = AlDar_1._0.Common_Class.Excel;

namespace AlDar_1._0.Window
{
    public partial class ProdPanel : Form
    {
        public ProdPanel()
        {
            InitializeComponent();
        }
        #region Methods
        public void DataSync()
        {
            dataGridView1.Rows.Clear();
            using(var context = new Models.DatabaseContext())
            {
                var products = context.Products.Where(p => p.Status == Status.Aktywny).ToList();
                foreach(var prod in products)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = prod.IdProduct.ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = prod.Name;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = prod.DefaultPrice.ToString();
                }
            }
        }
        public void Export()
        {
            using (var context = new Models.DatabaseContext())
            {
                var result = FolderForExport.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var path = FolderForExport.SelectedPath;
                    var fileName = "Export z dnia: " + DateTime.Now.ToString("Y") + ".xlsx";
                    var fullPath = path + @"\" + fileName;
                    Excel excel = new Excel();
                    if (File.Exists(fullPath))
                        File.Delete(fullPath);
                    excel.CreateExcel();
                    if (!File.Exists(fullPath))
                        excel.SaveAs(context.Products.Where(p => p.Status == Status.Aktywny).ToList(), path + @"\" + fileName);
                }
            }
        }
        #endregion
        #region Events
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void NewProdBtn_Click(object sender, EventArgs e)
        {
            AdditionalForm.ProduktAdd Add = new AdditionalForm.ProduktAdd();
            Add.ShowDialog();
            DataSync();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            var allId = new List<int>();
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells["CheckCol"].Value){
                    allId.Add(int.Parse(item.Cells[0].Value.ToString()));
                }
            }
            foreach(var Id in allId)
            {
                using(var context = new Models.DatabaseContext())
                {
                    context.Products.FirstOrDefault(p => p.IdProduct == Id).Status = Status.Nieaktywny;
                }
            }
            DataSync();
        }
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            var FromExcel = new AdditionalForm.AddFromExcel();
            FromExcel.ShowDialog();
            DataSync();
        }
        private void ExcelChangeBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy wyeksportowałeś już excela do zmiany?", "Export", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                var ChangeForm = new AdditionalForm.ChangeFromExcel();
                ChangeForm.ShowDialog();
                DataSync();
            }
            if (result == DialogResult.Cancel)
                return;
            if(result == DialogResult.No)
            {
                result = MessageBox.Show("Chcesz to zrobić teraz?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                Export();
            }
        }
        #endregion
    }
}
