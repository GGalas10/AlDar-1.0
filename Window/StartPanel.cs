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
    public partial class StartPanel : Form
    {
        public StartPanel()
        {
            InitializeComponent();
        }

        private void StartPanel_Load(object sender, EventArgs e)
        {
            HomeLbl.Text = "Witaj {użytkownik}.\nDzisiaj jest " + DateTime.Now.ToString("d")
                +".\nŁacznie posiadasz {val.count} wycen." +
                "\nDzisiaj zostało dodanych{val.where.count} wycen" +
                "\nOstatnia wycena była dla {val.lastindex.name}" +
                "\n";
            VerLbl.Text=("Wersja aplikacji {prop.ver}");
            
        }
    }
}
