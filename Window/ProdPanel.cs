using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Products = AlDar_1._0.Models.Products;
using Status = AlDar_1._0.Common_Class.Status;

namespace AlDar_1._0.Window
{
    public partial class ProdPanel : Form
    {
        public ProdPanel()
        {
            InitializeComponent();
        }
        public void DataSync()
        {
            //Auto clear and set data for datagridview
        }
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            var result = FolderForExport.ShowDialog();
            if(result == DialogResult.OK)
            {
                var path = FolderForExport.SelectedPath;
                var fileName = DateTime.Now.ToString("Y") + ".xlsx";
                //Add logic for xlsx save file
            }
        }

        private void NewProdBtn_Click(object sender, EventArgs e)
        {
            Window.ProduktAdd Add = new ProduktAdd();
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
                Products products = new Products();
                products.Status = Status.Nieaktywny;
            }
        }
    }
}
