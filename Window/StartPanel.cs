using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Settings = AlDar_1._0.Properties.Settings;
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
            using (var context = new Models.DatabaseContext())
            {
                HomeLbl.Text = "Witaj "+Settings.Default.UserName+
                    ".\nDzisiaj jest " + DateTime.Now.ToString("d")+
                    ".\nŁacznie posiadasz +context.Valuations.Count()+ wycen." +
                    "\nDzisiaj zostało dodanych+context.Valuations.Where(v=>v.AddDate == DateTime.Now+ wycen" +
                    "\nOstatnia wycena była dla {val.lastindex.name}"
                    +/*context.Valuations.FirstOrDefault(v=>v.IdVal == context.Valuations.Count()-1) +*/
                    "\n";
                VerLbl.Text = ("Wersja aplikacji " + AlDar_1._0.Properties.Settings.Default.Version);
                VerLbl.Location = new Point(780 - VerLbl.Size.Width, 480);
            }

        }
    }
}
