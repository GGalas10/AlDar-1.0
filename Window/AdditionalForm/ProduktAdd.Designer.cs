namespace AlDar_1._0.Window.AdditionalForm
{
    partial class ProduktAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduktAdd));
            this.NameLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.MeasureCombo = new System.Windows.Forms.ComboBox();
            this.MeasureLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(12, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(53, 19);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Nazwa";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Black;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(16, 118);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(233, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Dodaj produkt";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameBox.Location = new System.Drawing.Point(71, 6);
            this.NameBox.MaxLength = 100;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(174, 26);
            this.NameBox.TabIndex = 2;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.PriceBox.Location = new System.Drawing.Point(71, 41);
            this.PriceBox.MaxLength = 10;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(174, 26);
            this.PriceBox.TabIndex = 4;
            this.PriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceLbl.ForeColor = System.Drawing.Color.White;
            this.PriceLbl.Location = new System.Drawing.Point(12, 44);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(44, 19);
            this.PriceLbl.TabIndex = 3;
            this.PriceLbl.Text = "Cena";
            // 
            // MeasureCombo
            // 
            this.MeasureCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MeasureCombo.FormattingEnabled = true;
            this.MeasureCombo.Items.AddRange(new object[] {
            "Sztuka",
            "Metr kwadratowy",
            "Od dzieła",
            "Punkt",
            "Metr bieżący"});
            this.MeasureCombo.Location = new System.Drawing.Point(107, 85);
            this.MeasureCombo.Name = "MeasureCombo";
            this.MeasureCombo.Size = new System.Drawing.Size(138, 27);
            this.MeasureCombo.TabIndex = 5;
            this.MeasureCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MeasureCombo_KeyPress);
            // 
            // MeasureLbl
            // 
            this.MeasureLbl.AutoSize = true;
            this.MeasureLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MeasureLbl.ForeColor = System.Drawing.Color.White;
            this.MeasureLbl.Location = new System.Drawing.Point(12, 74);
            this.MeasureLbl.Name = "MeasureLbl";
            this.MeasureLbl.Size = new System.Drawing.Size(78, 38);
            this.MeasureLbl.TabIndex = 6;
            this.MeasureLbl.Text = "Jednostka\r\nmiary";
            // 
            // ProduktAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(257, 153);
            this.Controls.Add(this.MeasureLbl);
            this.Controls.Add(this.MeasureCombo);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(273, 152);
            this.Name = "ProduktAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie Produktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.ComboBox MeasureCombo;
        private System.Windows.Forms.Label MeasureLbl;
    }
}