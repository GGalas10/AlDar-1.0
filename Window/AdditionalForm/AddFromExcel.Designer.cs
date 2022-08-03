namespace AlDar_1._0.Window.AdditionalForm
{
    partial class AddFromExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFromExcel));
            this.FodlerBtn = new System.Windows.Forms.Button();
            this.FileDial = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadyBtn = new System.Windows.Forms.Button();
            this.TemplateBtn = new System.Windows.Forms.Button();
            this.folderBrow = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FodlerBtn
            // 
            this.FodlerBtn.BackColor = System.Drawing.Color.Black;
            this.FodlerBtn.FlatAppearance.BorderSize = 0;
            this.FodlerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FodlerBtn.ForeColor = System.Drawing.Color.White;
            this.FodlerBtn.Location = new System.Drawing.Point(12, 12);
            this.FodlerBtn.Name = "FodlerBtn";
            this.FodlerBtn.Size = new System.Drawing.Size(120, 29);
            this.FodlerBtn.TabIndex = 0;
            this.FodlerBtn.Text = "Wybierz plik excel";
            this.FodlerBtn.UseVisualStyleBackColor = false;
            this.FodlerBtn.Click += new System.EventHandler(this.FodlerBtn_Click);
            // 
            // FileDial
            // 
            this.FileDial.FileName = "openFileDialog1";
            this.FileDial.Filter = "Pliki Excel|*xlsx";
            this.FileDial.Title = "Wybieranie Excela";
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
            this.MeasureCol});
            this.dataGridView1.Location = new System.Drawing.Point(138, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(523, 477);
            this.dataGridView1.TabIndex = 5;
            // 
            // IdCol
            // 
            this.IdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.IdCol.FillWeight = 25F;
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.NameCol.FillWeight = 75F;
            this.NameCol.HeaderText = "Nazwa";
            this.NameCol.MinimumWidth = 75;
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // PriceCol
            // 
            this.PriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceCol.DefaultCellStyle = dataGridViewCellStyle7;
            this.PriceCol.FillWeight = 50F;
            this.PriceCol.HeaderText = "Domyślna cena";
            this.PriceCol.MinimumWidth = 50;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            // 
            // MeasureCol
            // 
            this.MeasureCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MeasureCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.MeasureCol.HeaderText = "Jednostka miary";
            this.MeasureCol.MinimumWidth = 75;
            this.MeasureCol.Name = "MeasureCol";
            this.MeasureCol.ReadOnly = true;
            this.MeasureCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ReadyBtn
            // 
            this.ReadyBtn.BackColor = System.Drawing.Color.Black;
            this.ReadyBtn.FlatAppearance.BorderSize = 0;
            this.ReadyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadyBtn.ForeColor = System.Drawing.Color.White;
            this.ReadyBtn.Location = new System.Drawing.Point(12, 421);
            this.ReadyBtn.Name = "ReadyBtn";
            this.ReadyBtn.Size = new System.Drawing.Size(120, 68);
            this.ReadyBtn.TabIndex = 6;
            this.ReadyBtn.Text = "Akceptuj";
            this.ReadyBtn.UseVisualStyleBackColor = false;
            this.ReadyBtn.Click += new System.EventHandler(this.ReadyBtn_Click);
            // 
            // TemplateBtn
            // 
            this.TemplateBtn.BackColor = System.Drawing.Color.Black;
            this.TemplateBtn.FlatAppearance.BorderSize = 0;
            this.TemplateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemplateBtn.ForeColor = System.Drawing.Color.White;
            this.TemplateBtn.Location = new System.Drawing.Point(12, 127);
            this.TemplateBtn.Name = "TemplateBtn";
            this.TemplateBtn.Size = new System.Drawing.Size(120, 70);
            this.TemplateBtn.TabIndex = 7;
            this.TemplateBtn.Text = "Zapisz szablon pliku";
            this.TemplateBtn.UseVisualStyleBackColor = false;
            this.TemplateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(673, 501);
            this.Controls.Add(this.TemplateBtn);
            this.Controls.Add(this.ReadyBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FodlerBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(689, 540);
            this.Name = "AddFromExcel";
            this.Text = "Dodawanie z excela";
            this.Load += new System.EventHandler(this.AddFromExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FodlerBtn;
        private System.Windows.Forms.OpenFileDialog FileDial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReadyBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureCol;
        private System.Windows.Forms.Button TemplateBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrow;
    }
}