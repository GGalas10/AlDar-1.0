using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = AlDar_1._0.Common_Class.Excel;

namespace AlDar_1._0.Window.AdditionalForm
{
    public partial class ChangeFromExcel : Form
    {
        List<Models.Products> productList = new List<Models.Products>();
        public ChangeFromExcel()
        {
            InitializeComponent();
        }

        private void FodlerBtn_Click(object sender, EventArgs e)
        {
            var result = FileDial.ShowDialog();
            if(result == DialogResult.OK)
            {
                Excel excel = new Excel();
                productList=excel.ReadCells(FileDial.FileName);
                using(var context = new Models.DatabaseContext())
                {
                    foreach(var item in productList)
                    {
                        if(item.Name == context.Products.FirstOrDefault(p => p.Name == item.Name).Name)
                        {
                            AddRows(DbGridView, context.Products.FirstOrDefault(p => p.Name == item.Name));
                        }
                    }
                }
            }
        }
        private void AddRows(DataGridView dataView, Models.Products prod)
        {
            dataView.Rows.Add();
            dataView.Rows[dataView.Rows.Count - 1].Cells[0].Value = prod.IdProduct;
            dataView.Rows[dataView.Rows.Count - 1].Cells[1].Value = prod.Name;
            dataView.Rows[dataView.Rows.Count - 1].Cells[2].Value = prod.DefaultPrice.ToString();
            dataView.Rows[dataView.Rows.Count - 1].Cells[3].Value = prod.Measure.ToString();
        }

    }
}
