using System;
using NLog;
using PowerArgs;

namespace RegexFileSearch
{
    public class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static int Main(string[] args)
        {
            Logger.Debug("Started");
            var isFound = false;
            try
            {
                Args.SearchAssemblyForRevivers();
                var commandLineArgs = Args.Parse<CommandLineArgs>(args);
                var fileSearcherFactory = new FileSearcherFactory();
                var fileSearcher = fileSearcherFactory.CreateFileSearcher(commandLineArgs.FilePath);
                isFound = fileSearcher.Search(commandLineArgs.FilePath, commandLineArgs.Regex);
            }
            catch (ArgException ex)
            {
                Logger.Error(ex, "Error while paring command line arguments");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

            Logger.Debug("Finished");
            return isFound ? 1 : 0;
        }
    }
}
