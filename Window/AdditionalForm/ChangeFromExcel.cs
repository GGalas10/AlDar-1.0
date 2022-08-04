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
        List<Models.Products> productListToChange = new List<Models.Products>();
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
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle cell = new DataGridViewCellStyle();
                        if(item.IdProduct == context.Products.FirstOrDefault(p => p.IdProduct == item.IdProduct).IdProduct)
                        {
                            productListToChange.Add(item);
                            AddRows(DbGridView, context.Products.FirstOrDefault(p => p.IdProduct == item.IdProduct));
                            AddRowsChange(ExportGridView, item, context.Products.FirstOrDefault(p => p.IdProduct == item.IdProduct));
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
        public void AddRowsChange(DataGridView dataview,Models.Products one, Models.Products two)
        {
            DataGridViewCellStyle cell = new DataGridViewCellStyle();
            cell.BackColor = System.Drawing.Color.Green;
            cell.ForeColor = System.Drawing.Color.White;
            cell.Font = new System.Drawing.Font("Times New Roman", 9.75f);
            dataview.Rows.Add();
            dataview.Rows[dataview.Rows.Count - 1].Cells[0].Value = one.IdProduct;
            if (one.Name != two.Name)
            {
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Style = cell;
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Value = one.Name;
            }
            else
            {
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Value = one.Name;
            }
            if (one.DefaultPrice != two.DefaultPrice)
            {
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Style = cell;
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Value = one.DefaultPrice;
            }
            else
            {
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Value = one.DefaultPrice;
            }
            if (one.Measure != two.Measure)
            {
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Style = cell;
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Value = one.Measure;
            }
            else
            {
                dataview.Rows[dataview.Rows.Count - 1].Cells[1].Value = one.Measure;
            }


        }
        private void DoneBtn_Click(object sender, EventArgs e)
        {
            using (var context = new Models.DatabaseContext()) {
                foreach (var prod in productListToChange)
                {
                    var ProductToChange = context.Products.FirstOrDefault(p => p.IdProduct == prod.IdProduct);
                    ProductToChange.Name = prod.Name;
                    ProductToChange.DefaultPrice = prod.DefaultPrice;
                    ProductToChange.Measure = prod.Measure;
                }
                if (context.SaveChanges() > 0)
                {

                }
            }
        }
    }
}
