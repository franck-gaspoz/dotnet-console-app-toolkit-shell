﻿using DotNetConsoleAppToolkit.Component.CommandLine;
using DotNetConsoleAppToolkit.Component.CommandLine.CommandLineReader;
using System;

namespace DotNetConsoleAppToolkitShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineProcessor = new CommandLineProcessor(args);
            var commandLineReader = new CommandLineReader(commandLineProcessor);
            var returnCode = commandLineReader.ReadCommandLine();
            Environment.Exit(returnCode);
        }
    }
}

