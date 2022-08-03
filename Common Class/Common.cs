using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;

namespace AlDar_1._0.Common_Class
{
    internal static class Common
    {

    }
    public enum Status
    {
        Aktywny,
        Nieaktywny
    }
    public enum ValStatus
    {
        Nowy,
        Archiwalne,
        Usunięte
    }
    public enum UMeasure
    {
        m2,
        mb,
        szt,
        pkt,
        dz,
    }
    public class Excel
    {
        static _Application excel = new _Excel.Application();
        static Workbook wb;
        static Worksheet ws;
        public void CreateExcel()
        {
            wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            ws = wb.Worksheets[1];
        }
        public void SaveAs(List<Models.Products> list,string path)
        {
            WriteToCell(1, 1, "Nazwa");
            WriteToCell(1, 2, "Cena");
            WriteToCell(1, 3, "Jednostka miary");
            for (int i = 1; i <= list.Count(); i++)
            {
                WriteToCell(i + 1, 1, list[i - 1].Name);
                WriteToCell(i + 1, 2, list[i - 1].DefaultPrice.ToString());
                WriteToCell(i + 1, 3, list[i - 1].Measure.ToString());
            }
            wb.SaveAs(path);
            wb.Close();
        }
        public void SaveAs(string path)
        {
            WriteToCell(1, 1, "Nazwa np. Malowanie");
            WriteToCell(1, 2, "Cena np. 25,15 (Używamy przecinków)");
            WriteToCell(1, 3, "Jednostka miary np. szt,mb,m2,dz,pkt");
            wb.SaveAs(path);
            wb.Close();
        }
        private void WriteToCell(int i, int j, string value)
        {

            ws.Cells[i, j].Value = value;
        }
        public List<Models.Products> ReadCells(string path)
        {
            List<Models.Products> ProductList = new List<Models.Products>();
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[1];
            try
            {
                for (int i = 2; i < ws.Rows.Count - 1; i++)
                {
                    if (ws.Rows.Cells[i, 1].Value2 != null)
                    {
                        Models.Products temp = new Models.Products();
                        temp.Name = ws.Cells[i, 1].Value2;                        
                        var floatTemp = ws.Cells[i, 2].Value2;
                        temp.DefaultPrice = float.Parse(floatTemp.ToString());
                        switch (ws.Cells[i, 3].Value2)
                        {
                            case "mb":
                                temp.Measure = UMeasure.mb;
                                break;
                            case "m2":
                                temp.Measure = UMeasure.m2;
                                break;
                            case "szt":
                                temp.Measure = UMeasure.szt;
                                break;
                            case "pkt":
                                temp.Measure = UMeasure.pkt;
                                break;
                            case "dz":
                                temp.Measure = UMeasure.dz;
                                break;
                            default:
                                temp.Measure = UMeasure.szt;
                                break;
                        }
                        ProductList.Add(temp);
                    }
                    else
                        break;
                }
            }
            finally
            {
                wb.Close();                
            }
            return ProductList;
        }
    }
}
