using System;
using System.IO;

namespace RegexFileSearch
{
    public class FileSearcherFactory
    {
        public IFileSearcher CreateFileSearcher(string filePath)
        {
            var extension = Path.GetExtension(filePath);
            switch (extension)
            {
                case ".txt":
                {
                    return new TxtFileSearcher();
                }
                case ".xlsx":
                {
                    return new XlsxFileSearcher();
                }
                default:
                {
                    throw new NotSupportedException(extension);
                }
            }
        }
    }
}
