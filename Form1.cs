﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlDar_1._0
{
    public partial class Form1 : Form
    {
        private Form ActiveForm;
        private Button ClickBtn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveForm = new Window.StartPanel();
            ActiveForm.TopLevel = false;
            this.panel2.Controls.Add(ActiveForm);
            ActiveForm.Show();
        }

        /// <summary>
        /// Get value and set right form to global ActiveForm variable
        /// </summary>
        /// <param name="choice"></param>
        /// 0 - Home Panel
        /// 1 - Valuation Panel
        /// 2 - Product Panel
        private void SetActiveFormForm(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(ActiveForm);
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "HomeBtn":
                    ActiveForm.Hide();
                    ActiveForm = new Window.StartPanel();
                    ActiveForm.TopLevel = false;
                    this.panel2.Controls.Add(ActiveForm);
                    ActiveForm.Show();
                    this.Text = "Start";
                    break;
                case "ValBtn":
                    ActiveForm.Hide();
                    ActiveForm = new Window.ValPanel();
                    ActiveForm.TopLevel = false;
                    this.panel2.Controls.Add(ActiveForm);
                    ActiveForm.Show();
                    this.Text = "Wyceny";
                    break;
                case "ProdBtn":
                    ActiveForm.Hide();
                    ActiveForm = new Window.ProdPanel();
                    ActiveForm.TopLevel = false;
                    this.panel2.Controls.Add(ActiveForm);
                    ActiveForm.Show();
                    this.Text = "Produkty";
                    break;
                default:
                    MessageBox.Show("Błąd podczas przekazywania wartości.");
                    break;
            }
        }
        /// <summary>
        /// Set clicked button and change style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click(object sender, EventArgs e)
        {
            if (ClickBtn != null)
            {
                ClickBtn.BackColor = Color.DimGray;
                ClickBtn.Font = new Font("Palatino Linotype", 14.25f);
                ClickBtn.ForeColor = Color.White;                
            }
            ClickBtn = (Button)sender;
            ClickBtn.BackColor = Color.White;
            ClickBtn.Font = new Font("Palatino Linotype", 15f, FontStyle.Bold);
            ClickBtn.ForeColor = Color.DimGray;
        }
    }
    
}
