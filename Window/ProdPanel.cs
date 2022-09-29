using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Status = AlDar_1._0.Common_Class.Status;
using Excel = AlDar_1._0.Common_Class.Excel;
using System.Windows;
using AlDar_1._0.Models;
using AlDar_1._0.Window.AdditionalForm;

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
            using(var context = new DatabaseContext())
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
            using (var context = new DatabaseContext())
            {
                var result = FolderForExport.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var path = FolderForExport.SelectedPath;
                    var fileName = "Export z dnia " + DateTime.Now.ToString("Y") + ".xlsx";
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
            using (var context = new DatabaseContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    var prod = context.Products.FirstOrDefault(p => p.IdProduct == id);
                    prod.Status = Status.Nieaktywny;
                    if (context.SaveChanges() > 0)
                        return;
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
            var result = MessBox.MessBox.Show("Czy wyeksportowałeś już excela do zmiany?", "Export", MessBox.TypeOfBox.YesCancelNo, MessBox.Icons.Info);
            if(result == MessageBoxResult.Yes)
            {
                var ChangeForm = new AdditionalForm.ChangeFromExcel();
                ChangeForm.ShowDialog();
                DataSync();
            }
            if (result == MessageBoxResult.Cancel)
                return;
            if(result == MessageBoxResult.No)
            {
                result = MessBox.MessBox.Show("Chcesz to zrobić teraz?", "Export", MessBox.TypeOfBox.YesCancelNo, MessBox.Icons.Info);
                if (result == MessageBoxResult.No)
                    return;
                Export();
            }
        }
        private void ProdPanel_Load(object sender, EventArgs e)
        {
            DataSync();
        }

        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var view = new ProdView(int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            view.ShowDialog();
            DataSync();
        }
    }
}
