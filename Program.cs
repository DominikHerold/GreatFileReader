using System;
using System.IO;

namespace GreatFileReader
{
    public class Program
    {
        private static void Main()
        {
            foreach (var line in File.ReadLines(@"C:\Projects\GreatFileReader\GreatFileReader.csproj"))
            {
                Console.WriteLine(line);
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
