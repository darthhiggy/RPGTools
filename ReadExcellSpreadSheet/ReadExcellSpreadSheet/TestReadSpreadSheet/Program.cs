using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadExcellSpreadSheet;
using System.IO;

namespace TestReadSpreadSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, @"SpreadSheets\SWRPG Ultimate GM Database v3.xlsx");
            if(!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exists");
                return;
            }

            var cells = ReadSpreadSheet.GetWorkSheetContent(filePath, 1);
            for(int i = 0; i < cells.GetLength(0); i++)
            {
                for(int j = 0; j < cells.GetLength(1); j++)
                {
                    Console.Write(cells[i, j] + "\t");
                    if(j == (cells.GetLength(1) -1))
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
