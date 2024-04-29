using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelSheetProgram
{
    public class ExcelSheet
    {
        public async Task<string> ConvertToTitle(int columnNumber)
        {
            string col_title = "";
            while (columnNumber > 0)
            {
                columnNumber--;
                char x = ((char)('A' + columnNumber % 26));
                col_title = x + col_title;
                columnNumber /= 26;
            }
            return col_title;
        }
    }
}
