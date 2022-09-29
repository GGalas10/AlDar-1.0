using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Excel = AlDar_1._0.Common_Class.Excel;
using AlDar_1._0.Models;

namespace AlDar_1._0.Window.AdditionalForm
{
    public partial class AddFromExcel : Form
    {
        List<BaseProducts> ProductList = new List<BaseProducts>();
        public AddFromExcel()
        {
            InitializeComponent();
        }
        private void FodlerBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
                    product.Status = Common_Class.Status.Aktywny;
                    product.DefaultQuantity = 1;
                }
            }
        }
        private void ReadyBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                List<BaseProducts> ContainProduct = new List<BaseProducts>();
                using (var context = new Models.DatabaseContext())
                {
                    foreach (var product in ProductList)
                    {
                        if (context.Products.FirstOrDefault(p => p.Name == product.Name) != null)
                        {
                            if (!BaseProducts.Equals(product, context.Products.FirstOrDefault(p => p.Name == product.Name)))
                                context.Products.Add(product);
                            else
                            {
                                ContainProduct.Add(context.Products.FirstOrDefault(p => p.Name == product.Name));
                            }
                        }
                        else
                            context.Products.Add(product);
                    }

                    if (context.SaveChanges() > 0)
                    {
                        MessBox.MessBox.Show("Udało się", "Produkty zostały dodane\n", MessBox.TypeOfBox.Ok, MessBox.Icons.Ok);
                    }
                    if (ContainProduct.Count > 0)
                    {
                        string temp = "";
                        foreach (var product in ContainProduct)
                        {
                            temp += "ID: " + product.IdProduct + ". Nazwa: " + product.Name + "\n";
                        }
                        MessBox.MessBox.Show("Błąd zapisu", "Produkty, które nie zostały dodane\n" + temp, MessBox.TypeOfBox.Ok, MessBox.Icons.Error);
                    }
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
