using System.IO;
using System.Linq;
using PowerArgs;

namespace RegexFileSearch
{
    public class ArgFileExtension : ArgValidator
    {
        private readonly string[] _validExtensions = {".txt", ".xlsx"};

        public override void Validate(string name, ref string arg)
        {
            if (!_validExtensions.Contains(Path.GetExtension(arg)))
            {
                throw new ValidationArgException("Incorrect file extension");
            }
        }
    }
}
