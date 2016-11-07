using System;
using System.IO;

using CommandLineParser.Arguments;
using CommandLineParser.Exceptions;

namespace GreatFileReader
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var parser = new CommandLineParser.CommandLineParser();
            var fileName = new ValueArgument<string>('f', "file", "fileName");
            parser.Arguments.Add(fileName);

            try
            {
                parser.ParseCommandLine(args);
            }
            catch (CommandLineException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var line in File.ReadLines(fileName.Value))
            {
                Console.WriteLine(line);
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
