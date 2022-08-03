using System;
using System.Windows.Forms;
using Settings = AlDar_1._0.Properties.Settings;

namespace AlDar_1._0.Window
{
    public partial class FirstTimePanel : Form
    {
        public FirstTimePanel()
        {
            InitializeComponent();
        }

        private void SelfBtn_Click(object sender, EventArgs e)
        {
            
            var result = FolderBrow.ShowDialog();
            if(result == DialogResult.OK)
            {
                PathBox.Text = FolderBrow.SelectedPath+@"\";
            }
        }

        private void DefBtn_Click(object sender, EventArgs e)
        {
            PathBox.Text = Settings.Default.DbPath + Settings.Default.DbName;
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.DbPath = FolderBrow.SelectedPath + @"\";
            Settings.Default.UserName = NameBox.Text.Trim();
            Settings.Default.FirstTime = false;
            Settings.Default.Save();
            using(var context = new Models.DatabaseContext())
            {
                context.Database.Create();
            }
            Application.Restart();
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
