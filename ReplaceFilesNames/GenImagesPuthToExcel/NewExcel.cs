using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace GenImagesPuthToExcel
{
    class NewExcel
    {
        private Excel.Application _application = null;
        private Excel.Workbook _workBook = null;
        private Excel.Worksheet _workSheet = null;
        private object _missingObj = System.Reflection.Missing.Value;

        public NewExcel()
        {
            _application = new Excel.Application();
            _workBook = _application.Workbooks.Add(_missingObj);
            _workSheet = (Excel.Worksheet)_workBook.Worksheets.get_Item(1);

        }

        public NewExcel(string pathToTemplate)
        {
            object pathToTemplateObj = pathToTemplate;

            _application = new Excel.Application();
            _workBook = _application.Workbooks.Add(pathToTemplateObj);
            _workSheet = (Excel.Worksheet)_workBook.Worksheets.get_Item(1);
        }

        public void SetCellValue(string cellValue, int rowIndex, int columnIndex)
        {
            _workSheet.Cells[rowIndex, columnIndex] = cellValue;
        }

        public bool Visible
        {
            get
            {
                return _application.Visible;
            }
            set
            {
                _application.Visible = value;
            }
        }
    }
}
