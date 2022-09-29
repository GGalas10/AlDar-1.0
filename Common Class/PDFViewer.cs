using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlDar_1._0.Common_Class
{
    public partial class PDFViewer : Form
    {
        string _File;
        public PDFViewer(string file)
        {     
            _File = file;
            InitializeComponent();
        }

        private void PDFViewer_Load(object sender, EventArgs e)
        {
            PDFFile.LoadFile(_File);
            PDFFile.src = _File;
        }
    }
}
