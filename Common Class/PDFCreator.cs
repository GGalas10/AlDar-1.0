using AlDar_1._0.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.IO;
using System.Linq;

namespace AlDar_1._0.Common_Class
{
    internal static class PDFCreator
    {
        static string _ValName;
        static string _ValPath;
        static Document pdfDoc;
        static Valuations _Valuation;


        public static void PreviewPDF(string name, Models.Valuations val)
        {
            _Valuation = val;
            _ValName = name + ".pdf";
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //Create documents with settings
            pdfDoc = new Document();
            pdfDoc.Info.Title = "Wycena: " + name;
            pdfDoc.Info.Subject = "Wycena dla klienta";
            pdfDoc.Info.Author = AlDar_1._0.Properties.Settings.Default.UserName;
            pdfDoc.DefaultPageSetup.LeftMargin = 30;
            pdfDoc.DefaultPageSetup.RightMargin = 30;
            pdfDoc.DefaultPageSetup.TopMargin = 30;
            pdfDoc.DefaultPageSetup.BottomMargin = 30;
            SetStyles();
            CreatePage();
            PdfDocumentRenderer renderPDF = new PdfDocumentRenderer();
            renderPDF.Document = pdfDoc;
            renderPDF.RenderDocument();
            Directory.CreateDirectory("C:\\Temp");
            renderPDF.Save("C:\\Temp\\Temp.pdf");
            var Viewer = new PDFViewer("C:\\Temp\\Temp.pdf");
            Viewer.ShowDialog();
            File.Delete("C:\\Temp\\Temp.pdf");
            Directory.Delete("C:\\Temp");
        }
        public static void CreatePDF(string name,string path,Models.Valuations val)
        {
            _Valuation = val;
            _ValName = name+".pdf";
            _ValPath = path+"\\";
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            
            //Create documents with settings
            pdfDoc = new Document();
            pdfDoc.Info.Title = "Wycena: "+name;
            pdfDoc.Info.Subject = "Wycena dla klienta";
            pdfDoc.Info.Author = AlDar_1._0.Properties.Settings.Default.UserName;
            SetStyles();
            CreatePage();
            SaveAsPDF(); 
        }
        public static void SaveAsPDF()
        {
            PdfDocumentRenderer renderPDF = new PdfDocumentRenderer();
            renderPDF.Document = pdfDoc;
            renderPDF.RenderDocument();
            _ValName = _ValName.Replace('/', '_');
            if (!File.Exists(_ValPath + _ValName))
            {
                if(!Directory.Exists(_ValPath))
                    Directory.CreateDirectory(_ValPath);
                renderPDF.Save(_ValPath+ _ValName);
            }
            else
            {
                //var result = MessBox.MessBox.Show("Plik istnieje", "Taki plik już istnieje w tym folderze.\nCzy chcesz go zamienić", MessBox.TypeOfBox.YesNo, MessBox.Icons.Info);
                //if (result == System.Windows.MessageBoxResult.Yes)
                    renderPDF.Save(_ValPath+ _ValName);
               // else
                   // return;
            }
        }
        public static void SetStyles()
        {
            Style style = pdfDoc.Styles["Normal"];
            style.Font.Name = "Times New Roman";

            //Header style (dateTime)
            style = pdfDoc.Styles.AddStyle("TimeStyle","Normal");
            style.Font.Size = 15;
            style.Font.Bold = true;
            style.ParagraphFormat.AddTabStop("0cm", TabAlignment.Right);


            //Subject style
            style = pdfDoc.Styles.AddStyle("Subject", "Normal");
            style.Font.Size = 18;
            style.ParagraphFormat.AddTabStop("0cm", TabAlignment.Center);


            //Title style

            style = pdfDoc.Styles.AddStyle("Title", "Normal");
            style.Font.Size = 30;
            style.Font.Bold = true;
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Center);

            //Table style

            style = pdfDoc.Styles.AddStyle("Table", "Normal");
            style.Font.Size = 14;
        }
        public static void CreatePage()
        {
            Section sectionPDF = pdfDoc.AddSection();
            var TimeSec = sectionPDF.AddParagraph();
            TimeSec.Format.Alignment = ParagraphAlignment.Right;
            var titleSec = sectionPDF.AddParagraph();
            titleSec.Style = "Title";
            titleSec.Format.Alignment = ParagraphAlignment.Center;

            var subjectSec = sectionPDF.AddParagraph();
            subjectSec.Style = "Subject";
            subjectSec.Format.Alignment = ParagraphAlignment.Center;

            
            TimeSec.AddText(DateTime.Now.ToString("d"));
            titleSec.AddText("Wycena");
            subjectSec.AddText(_Valuation.NameVal);


            var tableSec = sectionPDF.AddTable();
            tableSec.Style = "Table";
            tableSec.Borders.Color = new Color(0,0,0);
            Column col = tableSec.AddColumn("1.5cm");
            col.Format.Alignment = ParagraphAlignment.Left;

            col = tableSec.AddColumn("6cm");
            col.Format.Alignment = ParagraphAlignment.Left;

            col = tableSec.AddColumn("3cm");
            col.Format.Alignment = ParagraphAlignment.Left;

            col = tableSec.AddColumn("2cm");
            col.Format.Alignment = ParagraphAlignment.Left;

            col = tableSec.AddColumn("2cm");
            col.Format.Alignment = ParagraphAlignment.Left;

            col = tableSec.AddColumn("4cm");
            col.Format.Alignment = ParagraphAlignment.Left;

            Row row = tableSec.AddRow();
            row.HeadingFormat = true;
            row.Borders.Color = new Color(255, 255, 255);
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Shading.Color = new Color(0, 0, 0);
            row.Format.Font.Color = new Color(255, 255, 255);

            row.Cells[0].AddParagraph("L.P");
            row.Cells[1].AddParagraph("Nazwa");
            row.Cells[2].AddParagraph("Cena jednostkowa");
            row.Cells[3].AddParagraph("Ilość");
            row.Cells[4].AddParagraph("J.M.");
            row.Cells[5].AddParagraph("Cena");

            int i = 0;
            foreach(var prod in _Valuation.Productes.ToList()) { 
                row = tableSec.AddRow();
                if (i % 2 == 0)
                    row.Shading.Color = new Color(230, 230, 230);
                else
                    row.Shading.Color = new Color(255,255, 255);
                row.Cells[0].AddParagraph((i+1).ToString());
                row.Cells[1].AddParagraph(prod.Name);
                row.Cells[2].AddParagraph(prod.DefaultPrice.ToString("00.00"));
                row.Cells[3].AddParagraph(prod.DefaultQuantity.ToString());
                row.Cells[4].AddParagraph(prod.Measure.ToString());
                row.Cells[5].AddParagraph((prod.DefaultPrice*prod.DefaultQuantity).ToString("00.00"));
                i++;
            }
            row = tableSec.AddRow();
            row.Borders.Visible = false;

            row = tableSec.AddRow();
            row.Borders.Visible = false;
            row.Cells[4].Borders.Visible = true;
            row.Cells[4].Shading.Color = new Color(0, 0, 0);
            row.Cells[4].Format.Font.Color = new Color(255, 255, 255);
            row.Cells[5].Borders.Visible = true;
            row.Cells[5].Shading.Color = new Color(255,255, 255);
            row.Cells[5].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[4].AddParagraph("Kwota wyceny");
            row.Cells[5].AddParagraph(_Valuation.ValTotalAmount.ToString("00.00"));
        }
    }
}