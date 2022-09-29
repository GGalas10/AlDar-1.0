namespace AlDar_1._0.Common_Class
{
    partial class PDFViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFViewer));
            this.PDFFile = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PDFFile)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFFile
            // 
            this.PDFFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFFile.Enabled = true;
            this.PDFFile.Location = new System.Drawing.Point(0, 0);
            this.PDFFile.Name = "PDFFile";
            this.PDFFile.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFFile.OcxState")));
            this.PDFFile.Size = new System.Drawing.Size(534, 711);
            this.PDFFile.TabIndex = 0;
            // 
            // PDFViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 711);
            this.Controls.Add(this.PDFFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDFViewer";
            this.Text = "PDFViewer";
            this.Load += new System.EventHandler(this.PDFViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDFFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PDFFile;
    }
}