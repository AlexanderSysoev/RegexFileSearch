using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexFileSearch
{
    public class TxtFileSearcher : IFileSearcher
    {
        public bool Search(string filePath, Regex regex)
        {
            return File.ReadLines(filePath).Any(regex.IsMatch);
        }
    }
}
