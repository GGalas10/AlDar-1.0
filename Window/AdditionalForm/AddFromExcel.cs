using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Excel = AlDar_1._0.Common_Class.Excel;

namespace AlDar_1._0.Window.AdditionalForm
{
    public partial class AddFromExcel : Form
    {
        List<Models.Products> ProductList = new List<Models.Products>();
        public AddFromExcel()
        {
            InitializeComponent();
        }

        private void AddFromExcel_Load(object sender, EventArgs e)
        {

        }

        private void FodlerBtn_Click(object sender, EventArgs e)
        {
            var result = FileDial.ShowDialog();
            if (result == DialogResult.OK)
            {
                Excel excel = new Excel();                
                ProductList = excel.ReadCells(FileDial.FileName);
                foreach(var product in ProductList)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = dataGridView1.Rows.Count;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = product.Name;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = product.DefaultPrice;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = product.Measure;
                }
            }
        }

        private void ReadyBtn_Click(object sender, EventArgs e)
        {
            List<Models.Products> ContainProduct = new List<Models.Products>();
            using(var context = new Models.DatabaseContext())
            {
                foreach(var product in ProductList)
                {
                    if (!Models.Products.Equals(product, context.Products.FirstOrDefault(p => p.Name == product.Name)))
                        context.Products.Add(product);
                    else
                        ContainProduct.Add(context.Products.FirstOrDefault(p => p.Name == product.Name));
                }
                
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Zapis produktów udany");
                }
                if(ContainProduct.Count > 0)
                {
                    string temp="";
                    foreach(var product in ContainProduct)
                    {
                        temp += "ID: " + product.IdProduct + ". Nazwa: " + product.Name + "\n";
                    }
                    MessageBox.Show("Produkty, które nie zostały dodane\n"+temp);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = folderBrow.ShowDialog();
            if(result == DialogResult.OK)
            {
                Excel excel = new Excel();
                if (File.Exists(folderBrow.SelectedPath + @"\" + "Szablon_Produktów.xlsx"))
                    File.Delete(folderBrow.SelectedPath + @"\" + "Szablon_Produktów.xlsx");
                excel.CreateExcel();
                excel.SaveAs(folderBrow.SelectedPath+@"\"+"Szablon_Produktów.xlsx");
            }
        }
    }
}
