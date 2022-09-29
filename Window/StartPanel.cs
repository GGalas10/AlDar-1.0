using AlDar_1._0.Models;
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
            using (var context = new DatabaseContext())
            {               
                if (context.Valuations.ToList().Count() > 0)
                {
                    var list = context.Valuations.ToList();
                    HomeLbl.Text = "Witaj " + Settings.Default.UserName +
                        ".\nDzisiaj jest " + DateTime.Now.ToString("d") +
                        ".\nŁacznie posiadasz " + context.Valuations.Count().ToString() + " wycen" +
                        "\nDzisiaj zostało dodanych " + context.Valuations.Where(v=>v.AddDate.Day == DateTime.Now.Day)
                        .Where(v => v.AddDate.Month == DateTime.Now.Month)
                        .Where(v => v.AddDate.Year == DateTime.Now.Year).Count().ToString() + " wycen" +
                        "\nOstatnia wycena była dla " + list[list.Count-1].NameVal;
                    VerLbl.Text = ("Wersja aplikacji " + AlDar_1._0.Properties.Settings.Default.Version);
                    VerLbl.Location = new Point(780 - VerLbl.Size.Width, 480);
                }
                else
                {
                    HomeLbl.Text = "Witaj " + Settings.Default.UserName +
                       ".\nDzisiaj jest " + DateTime.Now.ToString("d") +
                       "\nBrak wycen w programie. Wybierz wyceny w górnym menu i stwórz swoją pierwszą wycenę";
                    VerLbl.Text = ("Wersja aplikacji " + AlDar_1._0.Properties.Settings.Default.Version);
                    VerLbl.Location = new Point(780 - VerLbl.Size.Width, 480);
                }
                }

            }
    }
}
