﻿namespace AlDar_1._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ValBtn = new System.Windows.Forms.Button();
            this.ProdBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ProdBtn);
            this.panel1.Controls.Add(this.ValBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeBtn.BackColor = System.Drawing.Color.DimGray;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(166, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(150, 50);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Start";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeBtn.UseVisualStyleBackColor = false;
            // 
            // ValBtn
            // 
            this.ValBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ValBtn.BackColor = System.Drawing.Color.DimGray;
            this.ValBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.ValBtn.ForeColor = System.Drawing.Color.White;
            this.ValBtn.Image = ((System.Drawing.Image)(resources.GetObject("ValBtn.Image")));
            this.ValBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValBtn.Location = new System.Drawing.Point(316, 0);
            this.ValBtn.Name = "ValBtn";
            this.ValBtn.Size = new System.Drawing.Size(150, 50);
            this.ValBtn.TabIndex = 1;
            this.ValBtn.Text = "Wyceny";
            this.ValBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValBtn.UseVisualStyleBackColor = false;
            // 
            // ProdBtn
            // 
            this.ProdBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProdBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProdBtn.BackColor = System.Drawing.Color.DimGray;
            this.ProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.ProdBtn.ForeColor = System.Drawing.Color.White;
            this.ProdBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProdBtn.Image")));
            this.ProdBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProdBtn.Location = new System.Drawing.Point(466, 0);
            this.ProdBtn.Name = "ProdBtn";
            this.ProdBtn.Size = new System.Drawing.Size(150, 50);
            this.ProdBtn.TabIndex = 2;
            this.ProdBtn.Text = "Produkty";
            this.ProdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProdBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 511);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu główne";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ProdBtn;
        private System.Windows.Forms.Button ValBtn;
        private System.Windows.Forms.Panel panel2;
    }
}

