using AlDar_1._0.Common_Class;
using AlDar_1._0.Models;
using AlDar_1._0.Window.AdditionalForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlDar_1._0.Window
{
    public partial class ValPanel : Form
    {
        MainMenu _Menu;
        public ValPanel(MainMenu menu)
        {
            _Menu = menu;
            InitializeComponent();
        }
        public void DataSync(Common_Class.ValStatus status)
        {
            dataGridView1.Rows.Clear();
            using (var context = new DatabaseContext())
            {
                var valList = context.Valuations.Where(v => v.Status == status).ToList();
                foreach (var val in valList)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = val.IdVal;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = dataGridView1.Rows.Count.ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = val.NameVal;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = val.ValTotalAmount;
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addValuation = new AdditionalForm.AddVal();
            addValuation.ShowDialog();
            DataSync(Common_Class.ValStatus.Nowy);
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                 using(var context = new DatabaseContext())
                {
                    if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value != null)
                    {
                        var Val = context.Valuations.FirstOrDefault(v => v.IdVal == int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        Val.Status = Common_Class.ValStatus.Archiwalne;
                    }
                }
            }
            DataSync(Common_Class.ValStatus.Nowy);
        }

        private void ArchiveBtn_Click(object sender, EventArgs e)
        {
            if(ArchiveBtn.Text == "Zakończone wyceny")
            {
                ArchiveBtn.Text = "Nowe wyceny";
                DataSync(Common_Class.ValStatus.Archiwalne);
                _Menu.Text = "Zakończone wyceny";
            }
            else
            {
                ArchiveBtn.Text = "Zakończone wyceny";
                DataSync(Common_Class.ValStatus.Nowy);
                _Menu.Text = "Nowe wyceny";               
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (var context = new DatabaseContext())
                {
                    if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value != null)
                    {
                        var Val = context.Valuations.FirstOrDefault(v => v.IdVal == int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        Val.Status = Common_Class.ValStatus.Usunięte;
                    }
                }
            }
            DataSync(Common_Class.ValStatus.Nowy);
        }

        private void ValPanel_Load(object sender, EventArgs e)
        {
            DataSync(Common_Class.ValStatus.Nowy);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4 &  e.RowIndex>=0 && !string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) )
            {
                using(var context = new DatabaseContext())
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var valuation = context.Valuations.FirstOrDefault(val => val.IdVal == id);
                    Common_Class.PDFCreator.PreviewPDF(valuation.NameVal, valuation);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 4 && !string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                using(var context = new DatabaseContext())
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var view = new ValView(context.Valuations.FirstOrDefault(val => val.IdVal == id));
                    view.ShowDialog();
                }
                DataSync(ValStatus.Nowy);
            }
        }
    }
}
