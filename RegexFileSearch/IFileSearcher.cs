using System.Text.RegularExpressions;

namespace RegexFileSearch
{
    public interface IFileSearcher
    {
        bool Search(string filePath, Regex regex);
    }
}
