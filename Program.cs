using System;
using System.Windows.Forms;
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
            //if (Settings.Default.FirstTime)
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new Window.FirstTimePanel());
            //}
            //else
            //{
            //    using (var context = new Models.DatabaseContext())
            //    {
            //        context.Database.Connection.OpenAsync();
            //    }
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new MainMenu());
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window.AdditionalForm.AddVal());
        }
    }
}
