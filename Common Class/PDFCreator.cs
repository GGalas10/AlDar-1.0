using PdfSharp.Drawing;
using PDF = PdfSharp.Pdf;
using System.Text;
using PdfSharp.Pdf;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Windows.Documents;
using PdfSharp.Drawing.Layout;

namespace AlDar_1._0.Common_Class
{
    internal static class PDFCreator
    {
        public static void CreatePDF(string title)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            PdfDocument newDoc = new PdfDocument();
            PdfPage page = newDoc.AddPage();
            XFont titleFont = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XGraphics XGh = XGraphics.FromPdfPage(page);
            XTextFormatter XTF = new XTextFormatter(XGh);
            XTF.DrawString(title, titleFont, XBrushes.Black,new XRect(0,0,page.Width,page.Height),XStringFormat.TopLeft);
            if (!Directory.Exists("C:\\Test"))
                Directory.CreateDirectory("C:\\Test");
            else
                newDoc.Save("C:\\Test\\test.pdf");

        }
    }
}
