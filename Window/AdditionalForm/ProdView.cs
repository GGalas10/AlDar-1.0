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
    public partial class ProdView : Form
    {
        bool anyChange=false;
        Products prod;
        int _Id;
        public ProdView(int id)
        {
            _Id = id;
            InitializeComponent();
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || (PriceBox.Text.Contains('.') && e.KeyChar == '.'))
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

        private void ProdView_Load(object sender, EventArgs e)
        {           
            using(var context = new DatabaseContext())
            {
                prod = context.Products.FirstOrDefault(p => p.IdProduct == _Id);
            }
            this.Text = prod.Name.ToUpper();
            nameBox.Text = prod.Name;
            PriceBox.Text = prod.DefaultPrice.ToString();
            switch (prod.Measure)
            {
                case Common_Class.UMeasure.szt:
                    MesBox.Text = "Sztuka";
                    break;
                case Common_Class.UMeasure.m2:
                    MesBox.Text = "Metr kwadratowy";
                    break;
                case Common_Class.UMeasure.dz:
                    MesBox.Text = "Od dzieła";
                    break;
                case Common_Class.UMeasure.pkt:
                    MesBox.Text = "Punkt";
                    break;
                case Common_Class.UMeasure.mb:
                    MesBox.Text = "Metr bieżący";
                    break;
                default:
                    MesBox.Text = "Błąd";
                    break;
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EditBtn.Text == "Edytuj")
            {
                EditBtn.Text = "Anuluj";
                this.MaximumSize = new Size(272, 295);
                this.Size = new Size(272, 295);
                this.MinimumSize = new Size(272, 295);
                saveBtn.Visible = true;
                nameBox.Enabled = true;
                PriceBox.Enabled = true;
                MesBox.Enabled = true;
            }
            else
            {
                EditBtn.Text = "Edytuj";
                this.MaximumSize = new Size(272, 250);
                this.Size = new Size(272, 219);
                this.MinimumSize = new Size(272, 250);
                saveBtn.Visible = false;
                nameBox.Enabled = false;
                PriceBox.Enabled = false;
                MesBox.Enabled = false;
            }
        }

        private void MesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Common_Class.UMeasure mes;
            switch (MesBox.Text)
            {
                case "Sztuka":
                    mes = Common_Class.UMeasure.szt;
                    break;
                case "Metr kwadratowy":
                    mes = Common_Class.UMeasure.m2;
                    break;
                case "Od dzieła":
                    mes = Common_Class.UMeasure.dz;
                    break;
                case "Punkt":
                    mes = Common_Class.UMeasure.pkt;
                    break;
                case "Metr bieżący":
                    mes = Common_Class.UMeasure.mb;
                    break;
                default:
                    return;
            }
            if (saveBtn.Visible)
            {
                if(nameBox.Text != prod.Name || float.Parse(PriceBox.Text) != prod.DefaultPrice || prod.Measure != mes)
                    anyChange = true;
                if (anyChange)
                {
                    using (var context = new DatabaseContext())
                    {
                        prod = context.Products.FirstOrDefault(p => p.IdProduct == _Id);
                        prod.Name = nameBox.Text;
                        prod.DefaultPrice = float.Parse(PriceBox.Text);
                        prod.Measure = mes;
                        if (context.SaveChanges() > 0)
                            MessBox.MessBox.Show("Sukces", "Zmiana produktu udała się", MessBox.TypeOfBox.Ok, MessBox.Icons.Ok);
                    }
                    this.Close();
                }
                else
                {
                    MessBox.MessBox.Show("Brak zmian", "Brak zmienionych danych", MessBox.TypeOfBox.Ok, MessBox.Icons.Info);
                }
                
            }

        }
    }
}
