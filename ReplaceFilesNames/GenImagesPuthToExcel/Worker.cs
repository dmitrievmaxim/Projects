using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace GenImagesPuthToExcel
{
    class Worker
    {
        public Worker()
        {
            GenStart();
        }

        private void GenStart()
        {
            /*
            Excel.Application excelapp = new Excel.Application();
            excelapp.Visible = false;
            Excel.Workbooks excelappworkbooks = excelapp.Workbooks;
            Excel.Workbook excelappworkbook = excelapp.Workbooks.Open(@"D:\Dev\CurrentProjects\Vlodke\Content\Price\Boats.xlsx",
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            Excel.Sheets excelsheets = excelappworkbook.Worksheets;
            Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            int usedRowsNum = excelworksheet.UsedRange.Rows.Count;
            Excel.Range cellRange;
            Excel.Range tmpColumn;
            int rowIndex = 1;
            int rowIndexPrilag = 1;
            */

            GenFileName();
            //
        }

        public void GenFileName()
        {
            List<String> allPuth = new List<string>();
            string Puth = "/Files/Img/Boats/";
            string generalPath = "d:\\Dev\\CurrentProjects\\Vlodke\\Content\\Images\\All";
            string[] directoriesName;
            directoriesName = System.IO.Directory.GetDirectories(generalPath);
            foreach(string s in directoriesName)
            {
                string[] subDirectory;
                var part_1 = new System.IO.DirectoryInfo(s).Name;
                subDirectory = System.IO.Directory.GetDirectories(s);
                foreach(string str in subDirectory)
                {
                    bool flag = false;
                    string tmp = Puth + part_1 + "/";
                    string once = tmp + new System.IO.DirectoryInfo(str).Name + "/";
                    string[] files = System.IO.Directory.GetFiles(str);
                    foreach(string st in files)
                    {
                        var part_2 = new System.IO.DirectoryInfo(st).Name;
                        if (flag == false)
                        {
                            once = once + part_2 + "|";
                            flag = true;
                        }
                        else once = once + tmp + part_2 + "|"; 
                    }
                    once = once.Remove(once.Length - 1);
                    allPuth.Add(once);
                }
            }

            NewExcel excel = new NewExcel(@"D:\NewExcel.xlsx");
            excel.Visible = true;
            
            for(int p = 0; p < allPuth.Count; p++)
            {
                excel.SetCellValue(allPuth[p], p + 1, 1);
            }
        }
    }
}

