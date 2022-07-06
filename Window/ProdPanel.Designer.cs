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
            this.NewProdBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProdBtn
            // 
            this.NewProdBtn.Location = new System.Drawing.Point(499, 12);
            this.NewProdBtn.Name = "NewProdBtn";
            this.NewProdBtn.Size = new System.Drawing.Size(289, 23);
            this.NewProdBtn.TabIndex = 1;
            this.NewProdBtn.Text = "Dodaj produkt";
            this.NewProdBtn.UseVisualStyleBackColor = true;
            // 
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(499, 50);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(289, 23);
            this.ImportBtn.TabIndex = 2;
            this.ImportBtn.Text = "Załaduj produkty z csv/excel";
            this.ImportBtn.UseVisualStyleBackColor = true;
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(499, 89);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(289, 23);
            this.ExportBtn.TabIndex = 3;
            this.ExportBtn.Text = "Pobierz produkty do csv/excel";
            this.ExportBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(499, 415);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(289, 23);
            this.DelBtn.TabIndex = 5;
            this.DelBtn.Text = "Usuń wybrany produkt";
            this.DelBtn.UseVisualStyleBackColor = true;
            // 
            // ProdPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.NewProdBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdPanel";
            this.Text = "ProdPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewProdBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DelBtn;
    }
}