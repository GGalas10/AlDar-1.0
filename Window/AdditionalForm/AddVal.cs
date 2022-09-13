using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlDar_1._0.Window.AdditionalForm
{
    public partial class AddVal : Form
    {
        #region Variable
        double price =0;
        int rowIndex,colindex;
        List<Models.Products> prodlist = new List<Models.Products>();
        List<Models.Products> temp = new List<Models.Products>();
        #endregion
        public AddVal()
        {
            InitializeComponent();
        }
        #region Testing
        public List<Models.Products> CreateTestProd()
        {
            string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Models.Products prod;
            Random random = new Random();
            StringBuilder stringer;
            var list = new List<Models.Products>();
            for(int i = 0; i <= 5; i++)
            {
                stringer = new StringBuilder();
                for (int j = 0; j <= 5; j++)
                {
                    stringer.Append(Characters[random.Next(0,Characters.Length-1)]);
                }
                prod = new Models.Products();
                prod.Name = stringer+i.ToString();
                prod.DefaultPrice = random.Next(1000);
                prod.IdProduct = random.Next(100);
                prod.DefaultQuantity = 1;
                prod.Measure = Common_Class.UMeasure.m2;
                list.Add(prod);
            }
            return list;
        }
        private void AddVal_Load(object sender, EventArgs e)
        {
            prodlist = CreateTestProd();
        }
        #endregion
        #region Events
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                colindex = dataGridView1.CurrentCell.ColumnIndex;
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                tb.TextChanged += new EventHandler(TextChange);
            }
            else
            {
                colindex = dataGridView1.CurrentCell.ColumnIndex;
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView2.Visible = false;
                dataGridView2.Enabled = false;               
            }
        }
        private void TextChange(object sender, EventArgs e)
        {
            if (colindex != 2)
                return;
            temp = prodlist.Where(p => p.Name.Contains((sender as TextBox).Text)).ToList();
            if (temp.Count <= 0)
            {
                dataGridView2.Visible = false;
                dataGridView2.Enabled = false;
                return;
            }
            dataGridView2.Rows.Clear();
            foreach(var item in temp)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.Rows.Count-1].Cells[0].Value = item.IdProduct;
                dataGridView2.Rows[dataGridView2.Rows.Count-1].Cells[1].Value = item.Name;
                dataGridView2.Rows[dataGridView2.Rows.Count-1].Cells[2].Value = item.DefaultPrice;
                
            }
            var rect = dataGridView1.GetCellDisplayRectangle(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex,true);
            dataGridView2.Location = new Point(dataGridView2.Location.X, rect.Bottom +40);
            dataGridView2.Size = new Size(dataGridView1.Size.Width, dataGridView2.Size.Height);
            dataGridView2.Columns[0].Width = dataGridView1.Columns[1].Width;
            dataGridView2.Columns[1].Width = dataGridView1.Columns[2].Width;
            dataGridView2.Columns[2].Width = dataGridView1.Columns[3].Width;
            dataGridView2.Visible = true;
            dataGridView2.Enabled = true;
            return;
        }
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            addData();
        }
        private void dataGridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (int)Keys.Escape)
            {
                GridViewFalse();
            }
            if(e.KeyValue == (int)Keys.Enter)
            {
                addData();
            }
        }
        private void dataGridView2_Leave(object sender, EventArgs e)
        {
            GridViewFalse();
        }
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            var DataRows = dataGridView1.Rows;
                foreach (DataGridViewRow Row in DataRows)
                {
                    if (Row.Cells[0].Value == null && Row.Index < e.Row.Index-1)
                    {
                        dataGridView1.Rows.Remove(Row);
                    }
                }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Escape)
            {
                GridViewFalse();
            }
            if(e.KeyValue == (int)Keys.Down || e.KeyValue == (int)Keys.Enter)
            {
                dataGridView2.Focus();
            }
        }
        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SetPrice();
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addData();
        }
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].IsNewRow || dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                return;           
            double textDouble = -1;
            if (!double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out textDouble) && e.ColumnIndex == 3)
            {
                if (textDouble <= 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Musi być liczba z maks 2 liczbami po przecinku większą od 0 np 19.19";
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                    return;
                }
            }
            int textInt = -1;
            if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out textInt) && e.ColumnIndex == 4)
            {
                if (textInt <= 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Musi być liczba naturalną większą od 0 np 5";
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                    return;
                }
            }
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
            if (e.ColumnIndex == 2 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {

                string prodName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var checkedProd = prodlist.FirstOrDefault(p => p.Name == prodName);
                if (checkedProd != null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = checkedProd.IdProduct;
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = e.RowIndex+1;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = checkedProd.Name;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = checkedProd.DefaultPrice;
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = checkedProd.DefaultQuantity;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = null;
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = null;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = null;
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = null;
                    dataGridView1.Rows[e.RowIndex].Cells[2].ErrorText = "Nie ma takiego przedmiotu w bazie danych";
                }
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods
        private void addData()
        {
            int id = int.Parse(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Models.Products prod = temp.FirstOrDefault(p => p.IdProduct == id);
            if (temp.Count() == 0)
                return;
            dataGridView1.Rows[rowIndex].Cells[0].Value = prod.IdProduct;
            dataGridView1.Rows[rowIndex].Cells[1].Value = rowIndex+1;
            dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Name;
            dataGridView1.Rows[rowIndex].Cells[3].Value = prod.DefaultPrice;
            dataGridView1.Rows[rowIndex].Cells[4].Value = prod.DefaultQuantity;
            dataGridView2.Rows.Clear();
            dataGridView1.Rows[rowIndex].Cells[2].ErrorText = "";
            GridViewFalse();
        }
        private void GridViewFalse()
        {
            dataGridView1.Focus();
            dataGridView2.Visible = false;
            dataGridView2.Enabled = false;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (Models.DatabaseContext context = new Models.DatabaseContext()) {
                Models.Valuations newValuation = new Models.Valuations();
                newValuation.Status = Common_Class.Status.Aktywny;
                newValuation.AddDate = DateTime.Now;
                if (string.IsNullOrEmpty(NameValBox.Text))
                {
                    MessBox.MessBox.Show("Błąd", "Trzeba wpisać nazwę wyceny", MessBox.TypeOfBox.Ok, MessBox.Icons.Warning);
                    return;
                }
                newValuation.NameVal = NameValBox.Text;
                double totalPrice=0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;
                    totalPrice = double.Parse(row.Cells[3].Value.ToString()) * double.Parse(row.Cells[4].Value.ToString());
                    Models.Products prod = new Models.Products();
                    prod = context.Products.FirstOrDefault(p => p.IdProduct == int.Parse(row.Cells[0].Value.ToString()));
                    prod.DefaultPrice = float.Parse(row.Cells[3].ToString());
                    prod.DefaultQuantity = int.Parse(row.Cells[4].ToString());
                    newValuation.Products.Add(prod);
                }
                newValuation.ValTotalAmount = (float)Math.Round(totalPrice, 2);
            }
        }
        private void SetPrice()
        {

            var dataRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                if (rows.Cells[3].Value != null && rows.Cells[4].Value != null)
                {
                    if (double.TryParse(rows.Cells[3].Value.ToString(), out price) && double.TryParse(rows.Cells[4].Value.ToString(), out price))
                    {
                        dataRows.Add(rows);
                    }
                }
            }
            price = 0;
            foreach (var row in dataRows)
            {
                price += double.Parse(row.Cells[3].Value.ToString()) * double.Parse(row.Cells[4].Value.ToString());
            }
            PriceLbl.Text = "Cena brutto: " + Math.Round(price, 2) + " zł";
        }
        #endregion
    }
}