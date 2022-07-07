namespace AlDar_1._0.Window
{
    partial class ValPanel
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ArchiveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.Location = new System.Drawing.Point(12, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(145, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Dodaj wycenę";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // DoneBtn
            // 
            this.DoneBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DoneBtn.Location = new System.Drawing.Point(164, 12);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(145, 23);
            this.DoneBtn.TabIndex = 1;
            this.DoneBtn.Text = "Zrealizuj wycenę";
            this.DoneBtn.UseVisualStyleBackColor = true;
            // 
            // DelBtn
            // 
            this.DelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DelBtn.Location = new System.Drawing.Point(315, 12);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(145, 23);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Usuń wycenę";
            this.DelBtn.UseVisualStyleBackColor = true;
            // 
            // ArchiveBtn
            // 
            this.ArchiveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ArchiveBtn.Location = new System.Drawing.Point(466, 12);
            this.ArchiveBtn.Name = "ArchiveBtn";
            this.ArchiveBtn.Size = new System.Drawing.Size(145, 23);
            this.ArchiveBtn.TabIndex = 3;
            this.ArchiveBtn.Text = "Archwialne wyceny";
            this.ArchiveBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 447);
            this.dataGridView1.TabIndex = 4;
            // 
            // ValPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ArchiveBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(784, 500);
            this.Name = "ValPanel";
            this.Text = "ValPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button ArchiveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}