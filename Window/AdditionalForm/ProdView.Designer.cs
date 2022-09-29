namespace AlDar_1._0.Window.AdditionalForm
{
    partial class ProdView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdView));
            this.NameLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.mesLbl = new System.Windows.Forms.Label();
            this.MesBox = new System.Windows.Forms.ComboBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(13, 9);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(58, 19);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Nazwa:";
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(98, 6);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.MaxLength = 50;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(148, 26);
            this.nameBox.TabIndex = 1;
            // 
            // PriceBox
            // 
            this.PriceBox.Enabled = false;
            this.PriceBox.Location = new System.Drawing.Point(98, 43);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceBox.MaxLength = 30;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(148, 26);
            this.PriceBox.TabIndex = 2;
            this.PriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLbl.ForeColor = System.Drawing.Color.White;
            this.priceLbl.Location = new System.Drawing.Point(13, 43);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(44, 19);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "Cena";
            // 
            // mesLbl
            // 
            this.mesLbl.AutoSize = true;
            this.mesLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesLbl.ForeColor = System.Drawing.Color.White;
            this.mesLbl.Location = new System.Drawing.Point(13, 77);
            this.mesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mesLbl.Name = "mesLbl";
            this.mesLbl.Size = new System.Drawing.Size(78, 38);
            this.mesLbl.TabIndex = 5;
            this.mesLbl.Text = "Jednostka\r\n miary";
            // 
            // MesBox
            // 
            this.MesBox.Enabled = false;
            this.MesBox.FormattingEnabled = true;
            this.MesBox.Items.AddRange(new object[] {
            "Sztuka",
            "Metr kwadratowy",
            "Od dzieła",
            "Punkt",
            "Metr bieżący"});
            this.MesBox.Location = new System.Drawing.Point(98, 88);
            this.MesBox.Name = "MesBox";
            this.MesBox.Size = new System.Drawing.Size(148, 27);
            this.MesBox.TabIndex = 6;
            this.MesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MesBox_KeyPress);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Black;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(10, 135);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(236, 33);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(10, 174);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(236, 33);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Wróć";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Black;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(10, 213);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(236, 33);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ProdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(256, 211);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.MesBox);
            this.Controls.Add(this.mesLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.NameLbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(272, 250);
            this.MinimumSize = new System.Drawing.Size(272, 250);
            this.Name = "ProdView";
            this.Text = "ProdView";
            this.Load += new System.EventHandler(this.ProdView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label mesLbl;
        private System.Windows.Forms.ComboBox MesBox;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}