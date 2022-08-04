namespace AlDar_1._0.Window
{
    partial class ProdPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewProdBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ExcelChangeBtn = new System.Windows.Forms.Button();
            this.FolderForExport = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProdBtn
            // 
            this.NewProdBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewProdBtn.BackColor = System.Drawing.Color.Black;
            this.NewProdBtn.FlatAppearance.BorderSize = 0;
            this.NewProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProdBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewProdBtn.ForeColor = System.Drawing.Color.White;
            this.NewProdBtn.Location = new System.Drawing.Point(12, 12);
            this.NewProdBtn.Name = "NewProdBtn";
            this.NewProdBtn.Size = new System.Drawing.Size(215, 32);
            this.NewProdBtn.TabIndex = 1;
            this.NewProdBtn.Text = "Dodaj produkt";
            this.NewProdBtn.UseVisualStyleBackColor = false;
            this.NewProdBtn.Click += new System.EventHandler(this.NewProdBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NameCol,
            this.PriceCol,
            this.CheckCol});
            this.dataGridView1.Location = new System.Drawing.Point(233, 12);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(481, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 487);
            this.dataGridView1.TabIndex = 4;
            // 
            // IdCol
            // 
            this.IdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdCol.FillWeight = 25F;
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameCol.FillWeight = 75F;
            this.NameCol.HeaderText = "Nazwa";
            this.NameCol.MinimumWidth = 75;
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // PriceCol
            // 
            this.PriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.PriceCol.FillWeight = 50F;
            this.PriceCol.HeaderText = "Domyślna cena";
            this.PriceCol.MinimumWidth = 50;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            // 
            // CheckCol
            // 
            this.CheckCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.CheckCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.CheckCol.FillWeight = 50F;
            this.CheckCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckCol.HeaderText = "Zaznaczenie";
            this.CheckCol.MinimumWidth = 50;
            this.CheckCol.Name = "CheckCol";
            this.CheckCol.ReadOnly = true;
            // 
            // ExportBtn
            // 
            this.ExportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportBtn.BackColor = System.Drawing.Color.Black;
            this.ExportBtn.FlatAppearance.BorderSize = 0;
            this.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportBtn.ForeColor = System.Drawing.Color.White;
            this.ExportBtn.Location = new System.Drawing.Point(12, 50);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(215, 32);
            this.ExportBtn.TabIndex = 6;
            this.ExportBtn.Text = "Exportuj pliki do excela";
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportBtn.BackColor = System.Drawing.Color.Black;
            this.ImportBtn.FlatAppearance.BorderSize = 0;
            this.ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImportBtn.ForeColor = System.Drawing.Color.White;
            this.ImportBtn.Location = new System.Drawing.Point(12, 456);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(215, 32);
            this.ImportBtn.TabIndex = 7;
            this.ImportBtn.Text = "Dodaj produkty z excela";
            this.ImportBtn.UseVisualStyleBackColor = false;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DelBtn.BackColor = System.Drawing.Color.Black;
            this.DelBtn.FlatAppearance.BorderSize = 0;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(12, 88);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(215, 32);
            this.DelBtn.TabIndex = 8;
            this.DelBtn.Text = "Usuń wybrane produkty\r\n";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ExcelChangeBtn
            // 
            this.ExcelChangeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExcelChangeBtn.BackColor = System.Drawing.Color.Black;
            this.ExcelChangeBtn.FlatAppearance.BorderSize = 0;
            this.ExcelChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelChangeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExcelChangeBtn.ForeColor = System.Drawing.Color.White;
            this.ExcelChangeBtn.Location = new System.Drawing.Point(12, 418);
            this.ExcelChangeBtn.Name = "ExcelChangeBtn";
            this.ExcelChangeBtn.Size = new System.Drawing.Size(215, 32);
            this.ExcelChangeBtn.TabIndex = 9;
            this.ExcelChangeBtn.Text = "Zmień produkty przez excel";
            this.ExcelChangeBtn.UseVisualStyleBackColor = false;
            this.ExcelChangeBtn.Click += new System.EventHandler(this.ExcelChangeBtn_Click);
            // 
            // ProdPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.ExcelChangeBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewProdBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(784, 511);
            this.Name = "ProdPanel";
            this.Text = "ProdPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewProdBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button ExcelChangeBtn;
        private System.Windows.Forms.FolderBrowserDialog FolderForExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckCol;
    }
}