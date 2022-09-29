﻿using AlDar_1._0.Models;
using System;
using System.IO;
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
        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.DbPath = Directory.GetCurrentDirectory() + Settings.Default.DbPath;
            Directory.CreateDirectory(Settings.Default.DbPath);
            Settings.Default.UserName = NameBox.Text.Trim();
            Settings.Default.FirstTime = false;
            Settings.Default.Save();
            using(var context = new DatabaseContext())
            {
                context.Database.CreateIfNotExists();
            }
            Application.Restart();
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
