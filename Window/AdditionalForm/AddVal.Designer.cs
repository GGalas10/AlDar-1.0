namespace AlDar_1._0.Window.AdditionalForm
{
    partial class AddVal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVal));
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameValBox = new System.Windows.Forms.TextBox();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SavePDFBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IdHint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceHint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(15, 11);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(58, 19);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Nazwa:";
            // 
            // NameValBox
            // 
            this.NameValBox.Location = new System.Drawing.Point(81, 8);
            this.NameValBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameValBox.MaxLength = 100;
            this.NameValBox.Name = "NameValBox";
            this.NameValBox.Size = new System.Drawing.Size(198, 26);
            this.NameValBox.TabIndex = 1;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TimeLbl.ForeColor = System.Drawing.Color.White;
            this.TimeLbl.Location = new System.Drawing.Point(557, 11);
            this.TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(118, 19);
            this.TimeLbl.TabIndex = 0;
            this.TimeLbl.Text = "Data 04.08.2022";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.IdCol,
            this.NameCol,
            this.PriceCol,
            this.QCol,
            this.DelCol});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(652, 314);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // IdCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdCol.HeaderText = "Id";
            this.IdCol.MinimumWidth = 20;
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameCol.FillWeight = 150F;
            this.NameCol.HeaderText = "Nazwa";
            this.NameCol.MaxInputLength = 50;
            this.NameCol.MinimumWidth = 150;
            this.NameCol.Name = "NameCol";
            this.NameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.PriceCol.FillWeight = 120F;
            this.PriceCol.HeaderText = "Cena";
            this.PriceCol.MinimumWidth = 120;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QCol
            // 
            this.QCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.QCol.FillWeight = 50F;
            this.QCol.HeaderText = "Ilość";
            this.QCol.MinimumWidth = 50;
            this.QCol.Name = "QCol";
            this.QCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DelCol
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DelCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.DelCol.FillWeight = 50F;
            this.DelCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelCol.HeaderText = "Usuń";
            this.DelCol.MinimumWidth = 50;
            this.DelCol.Name = "DelCol";
            // 
            // SavePDFBtn
            // 
            this.SavePDFBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePDFBtn.BackColor = System.Drawing.Color.Black;
            this.SavePDFBtn.FlatAppearance.BorderSize = 0;
            this.SavePDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePDFBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SavePDFBtn.ForeColor = System.Drawing.Color.White;
            this.SavePDFBtn.Location = new System.Drawing.Point(552, 447);
            this.SavePDFBtn.Name = "SavePDFBtn";
            this.SavePDFBtn.Size = new System.Drawing.Size(120, 56);
            this.SavePDFBtn.TabIndex = 5;
            this.SavePDFBtn.Text = "Zapisz z plikiem PDF";
            this.SavePDFBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.Black;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(271, 447);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 56);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.Black;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(12, 447);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 56);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Anuluj";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHint,
            this.NameHint,
            this.PriceHint});
            this.dataGridView2.Location = new System.Drawing.Point(12, 112);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(652, 130);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            this.dataGridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyUp);
            this.dataGridView2.Leave += new System.EventHandler(this.dataGridView2_Leave);
            // 
            // IdHint
            // 
            this.IdHint.HeaderText = "Id";
            this.IdHint.MinimumWidth = 25;
            this.IdHint.Name = "IdHint";
            this.IdHint.ReadOnly = true;
            // 
            // NameHint
            // 
            this.NameHint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameHint.HeaderText = "Nazwa";
            this.NameHint.Name = "NameHint";
            this.NameHint.ReadOnly = true;
            // 
            // PriceHint
            // 
            this.PriceHint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceHint.HeaderText = "Cena";
            this.PriceHint.Name = "PriceHint";
            this.PriceHint.ReadOnly = true;
            // 
            // PriceLbl
            // 
            this.PriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.PriceLbl.ForeColor = System.Drawing.Color.White;
            this.PriceLbl.Location = new System.Drawing.Point(454, 368);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(93, 19);
            this.PriceLbl.TabIndex = 0;
            this.PriceLbl.Text = "Cena brutto:";
            // 
            // AddVal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 515);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SavePDFBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.NameValBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.PriceLbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(700, 554);
            this.Name = "AddVal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie Wyceny";
            this.Load += new System.EventHandler(this.AddVal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameValBox;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SavePDFBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceHint;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCol;
        private System.Windows.Forms.DataGridViewButtonColumn DelCol;
    }
}