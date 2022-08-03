namespace AlDar_1._0.Window
{
    partial class FirstTimePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimePanel));
            this.DefBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelfBtn = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.FolderBrow = new System.Windows.Forms.FolderBrowserDialog();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DefBtn
            // 
            this.DefBtn.Location = new System.Drawing.Point(16, 75);
            this.DefBtn.Name = "DefBtn";
            this.DefBtn.Size = new System.Drawing.Size(306, 23);
            this.DefBtn.TabIndex = 0;
            this.DefBtn.Text = "Domyślne";
            this.DefBtn.UseVisualStyleBackColor = true;
            this.DefBtn.Click += new System.EventHandler(this.DefBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(153, 8);
            this.NameBox.MaxLength = 50;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(169, 22);
            this.NameBox.TabIndex = 1;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLbl.Location = new System.Drawing.Point(12, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(140, 21);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Podaj swoje imię:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz miejsce zapisu bazy danych";
            // 
            // SelfBtn
            // 
            this.SelfBtn.Location = new System.Drawing.Point(16, 104);
            this.SelfBtn.Name = "SelfBtn";
            this.SelfBtn.Size = new System.Drawing.Size(306, 23);
            this.SelfBtn.TabIndex = 4;
            this.SelfBtn.Text = "Moje miejsce";
            this.SelfBtn.UseVisualStyleBackColor = true;
            this.SelfBtn.Click += new System.EventHandler(this.SelfBtn_Click);
            // 
            // PathBox
            // 
            this.PathBox.Enabled = false;
            this.PathBox.Location = new System.Drawing.Point(16, 133);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(306, 22);
            this.PathBox.TabIndex = 5;
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(16, 161);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(306, 42);
            this.DoneBtn.TabIndex = 6;
            this.DoneBtn.Text = "Wszystko się zgadza. Zaczynajmy";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // FirstTimePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(334, 208);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.SelfBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DefBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(350, 247);
            this.Name = "FirstTimePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pierwsze ustawienie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DefBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelfBtn;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrow;
        private System.Windows.Forms.Button DoneBtn;
    }
}