using DotNetConsoleAppToolkit.Component.CommandLine.CommandLineReader;
using System;
using static DotNetConsoleAppToolkit.Component.CommandLine.CommandLineProcessor;

namespace DotNetConsoleAppToolkitShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineReader = new CommandLineReader();
            InitializeCommandProcessor(args,commandLineReader);
            var returnCode = commandLineReader.ReadCommandLine();
            Environment.Exit(returnCode);
        }
    }
}

