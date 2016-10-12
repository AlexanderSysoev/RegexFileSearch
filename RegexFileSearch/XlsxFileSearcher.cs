using System.IO;
using System.Text.RegularExpressions;
using OfficeOpenXml;

namespace RegexFileSearch
{
    public class XlsxFileSearcher : IFileSearcher
    {
        public bool Search(string filePath, Regex regex)
        {
            var package = new ExcelPackage(new FileInfo(filePath));
            foreach (var workSheet in package.Workbook.Worksheets)
            {
                var start = workSheet.Dimension.Start;
                var end = workSheet.Dimension.End;
                for (var row = start.Row; row <= end.Row; row++)
                {
                    for (var col = start.Column; col <= end.Column; col++)
                    {
                        if (regex.IsMatch(workSheet.Cells[row, col].Text))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
