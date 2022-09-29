using AlDar_1._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlDar_1._0.Window.AdditionalForm
{
    public partial class ProduktAdd : Form
    {
        public ProduktAdd()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            using (var context = new DatabaseContext())
            {
                if (!string.IsNullOrEmpty(PriceBox.Text) && !string.IsNullOrEmpty(NameBox.Text) && !string.IsNullOrEmpty(MeasureCombo.Text))
                {
                    var products = new BaseProducts();
                    products.Name = NameBox.Text;
                    products.DefaultPrice = (float)Math.Round(double.Parse(PriceBox.Text),2);
                    products.DefaultQuantity = 1;
                    products.Status = Common_Class.Status.Aktywny;
                    switch (MeasureCombo.Text)
                    {
                        case "Sztuka":
                            products.Measure = Common_Class.UMeasure.szt;
                            break;
                        case "Metr kwadratowy":
                            products.Measure = Common_Class.UMeasure.m2;
                            break;
                        case "Od dzieła":
                            products.Measure = Common_Class.UMeasure.dz;
                            break;
                        case "Punkt":
                            products.Measure = Common_Class.UMeasure.pkt;
                            break;
                        case "Metr bieżący":
                            products.Measure = Common_Class.UMeasure.mb;
                            break;
                        default:
                            return;
                    }
                    var result =
                        MessageBox.Show(
                        "Na pewno te dane pasują?\n" +
                        "Nazwa: " + NameBox.Text + "\n" +
                        "Cena: " + products.DefaultPrice + " zł\n" +
                        "Jednostka miary: " + products.Measure.ToString(),
                        "Czy na pewno?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question); ;
                    if(result == DialogResult.Yes)
                    {
                        context.Products.Add(products);
                        if (context.SaveChanges() > 0)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || (PriceBox.Text.Contains('.') && e.KeyChar=='.'))
            {
                e.Handled = true;
            }                
            if (e.KeyChar == '.')
            {

                if (this.Text.IndexOf(".") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void MeasureCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
