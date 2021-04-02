using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OpenEmrApplication.Utilities
{
    class ExcelUtils
    {
        public static DataTable SheetToDataTable(string path,string sheetname)
        {
            DataTable dt = new DataTable();

            using (XLWorkbook book = new XLWorkbook(path))
            {
                IXLWorksheet sheet = book.Worksheet(sheetname);
                int rowCount = sheet.RangeUsed().RowCount();
                int colCount = sheet.RangeUsed().ColumnCount();

                //fill coulmn
                for (int c = 1; c <= colCount; c++)
                {
                    //Console.WriteLine(sheet.Row(1).Cell(c).GetString());
                    dt.Columns.Add(sheet.Row(1).Cell(c).GetString());
                }

                //fill row
                for (int r = 2; r <= rowCount; r++)
                {
                    DataRow row = dt.NewRow();
                    for (int c = 1; c <= colCount; c++)
                    {
                       // Console.WriteLine(sheet.Row(r).Cell(c).GetString());
                        row[c - 1] = sheet.Row(r).Cell(c).GetString();
                    }
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
    }
}
