using System;
using System.Windows.Forms;
using AlDar_1._0.Models;
using AlDar_1._0.Window;
using AlDar_1._0.Window.AdditionalForm;
using Settings = AlDar_1._0.Properties.Settings;
namespace AlDar_1._0
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (Settings.Default.FirstTime)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Window.FirstTimePanel());
            }
            else
            {
                using (var context = new DatabaseContext())
                {
                    context.Database.Connection.Open();
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainMenu());
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ProdPanel());
        }
    }
}
