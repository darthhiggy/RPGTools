using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excell = Microsoft.Office.Interop.Excel;

namespace ReadExcellSpreadSheet
{
    public static class ReadSpreadSheet
    {
        // open excell application
        public static Excell.Application OpenApplication() => new Excell.Application();
        // Open Excell workbook
        public static Excell.Workbook OpenSpreadSheet(Excell.Application xlApp, string workbookPath)
        {
            Excell.Workbook xlWorkbook = xlApp.Workbooks.Open(workbookPath);
            return xlWorkbook;            
        }

        // open Excell SpreadSheet From Excell Application
        public static Excell._Worksheet OpenWorkSheet(Excell.Workbook workBook, int sheetNum) => workBook.Sheets[sheetNum];

        // get Range from worksheet
        public static Excell.Range GetRange(Excell._Worksheet workSheet) => workSheet.UsedRange;

        // col length from range
        public static int GetColLength(Excell.Range range) => range.Columns.Count;

        // row length from range
        public static int GetRowLength(Excell.Range range) => range.Rows.Count;

        // get cell content given row, col
        public static string GetCellContent(int row, int colomn, Excell.Range range) => range.Cells[row, colomn].Value2.ToString();

        // cleanup and close application 
        public static void CleanUp(Excell.Workbook xlWorkbook, Excell.Range xlRange, Excell._Worksheet xlWorksheet, Excell.Application xlApp)
        {
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        public static string[,] GetWorkSheetContent(string excellPath, int worksheetNumber)
        {
            var app = OpenApplication();
            var workbook = OpenSpreadSheet(app, excellPath);
            var workSheet = OpenWorkSheet(workbook, worksheetNumber);
            var range = GetRange(workSheet);
            string[,] cells = new string[range.Rows.Count, range.Columns.Count];

            for(int i = 1; i <= range.Rows.Count; i++)
            {
                for(int j = 1; j <= range.Columns.Count; j++)
                {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                    {
                        cells[i - 1, j - 1] = range.Cells[i, j].Value2.ToString();
                    }
                }
            }

            CleanUp(workbook, range, workSheet, app);

            return cells;
        }
    }
}
