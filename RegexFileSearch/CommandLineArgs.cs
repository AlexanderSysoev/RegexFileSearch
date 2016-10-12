using System;
using System.Text.RegularExpressions;
using PowerArgs;

namespace RegexFileSearch
{
    public class CommandLineArgs
    {
        [ArgRequired(PromptIfMissing = true)]
        [ArgDescription("Search regular expression pattern")]
        [ArgShortcut("r")]
        public Regex Regex { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        [ArgDescription("txt or xlsx file path")]
        [ArgShortcut("p")]
        [ArgExistingFile]
        [ArgFileExtension]
        public string FilePath { get; set; }

        [ArgReviver]
        public static Regex Revive(string key, string val)
        {
            try
            {
                return new Regex(val, RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);
            }
            catch (Exception ex)
            {
                throw new ArgException("Incorrect regex pattern", ex);
            }
        }
    }
}
