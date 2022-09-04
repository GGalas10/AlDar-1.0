namespace AlDar_1._0.Window.AdditionalForm
{
    partial class ChangeFromExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeFromExcel));
            this.DbGridView = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FodlerBtn = new System.Windows.Forms.Button();
            this.FileDial = new System.Windows.Forms.OpenFileDialog();
            this.ExportGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoneBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridView
            // 
            this.DbGridView.AllowUserToAddRows = false;
            this.DbGridView.AllowUserToDeleteRows = false;
            this.DbGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DbGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.DbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NameCol,
            this.PriceCol,
            this.MeasureCol});
            this.DbGridView.Location = new System.Drawing.Point(13, 48);
            this.DbGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DbGridView.MultiSelect = false;
            this.DbGridView.Name = "DbGridView";
            this.DbGridView.ReadOnly = true;
            this.DbGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DbGridView.Size = new System.Drawing.Size(455, 599);
            this.DbGridView.TabIndex = 6;
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
            // MeasureCol
            // 
            this.MeasureCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MeasureCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.MeasureCol.HeaderText = "Jednostka miary";
            this.MeasureCol.MinimumWidth = 75;
            this.MeasureCol.Name = "MeasureCol";
            this.MeasureCol.ReadOnly = true;
            this.MeasureCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FodlerBtn
            // 
            this.FodlerBtn.BackColor = System.Drawing.Color.Black;
            this.FodlerBtn.FlatAppearance.BorderSize = 0;
            this.FodlerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FodlerBtn.ForeColor = System.Drawing.Color.White;
            this.FodlerBtn.Location = new System.Drawing.Point(13, 12);
            this.FodlerBtn.Name = "FodlerBtn";
            this.FodlerBtn.Size = new System.Drawing.Size(120, 29);
            this.FodlerBtn.TabIndex = 7;
            this.FodlerBtn.Text = "Wybierz plik excel";
            this.FodlerBtn.UseVisualStyleBackColor = false;
            this.FodlerBtn.Click += new System.EventHandler(this.FodlerBtn_Click);
            // 
            // FileDial
            // 
            this.FileDial.FileName = "openFileDialog1";
            this.FileDial.Filter = "Pliki Excel|*.xlsx";
            // 
            // ExportGridView
            // 
            this.ExportGridView.AllowUserToAddRows = false;
            this.ExportGridView.AllowUserToDeleteRows = false;
            this.ExportGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ExportGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.ExportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ExportGridView.Location = new System.Drawing.Point(543, 48);
            this.ExportGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ExportGridView.MultiSelect = false;
            this.ExportGridView.Name = "ExportGridView";
            this.ExportGridView.ReadOnly = true;
            this.ExportGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ExportGridView.Size = new System.Drawing.Size(492, 599);
            this.ExportGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.FillWeight = 75F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Domyślna cena";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "Jednostka miary";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DoneBtn
            // 
            this.DoneBtn.BackColor = System.Drawing.Color.Black;
            this.DoneBtn.FlatAppearance.BorderSize = 0;
            this.DoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBtn.ForeColor = System.Drawing.Color.White;
            this.DoneBtn.Location = new System.Drawing.Point(915, 12);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(120, 29);
            this.DoneBtn.TabIndex = 9;
            this.DoneBtn.Text = "Akceptuje";
            this.DoneBtn.UseVisualStyleBackColor = false;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // ChangeFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1048, 660);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.ExportGridView);
            this.Controls.Add(this.FodlerBtn);
            this.Controls.Add(this.DbGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1064, 699);
            this.Name = "ChangeFromExcel";
            this.Text = "Zmiana produktów";
            ((System.ComponentModel.ISupportInitialize)(this.DbGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureCol;
        private System.Windows.Forms.Button FodlerBtn;
        private System.Windows.Forms.OpenFileDialog FileDial;
        private System.Windows.Forms.DataGridView ExportGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button DoneBtn;
    }
}