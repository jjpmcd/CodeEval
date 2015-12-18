using System;
using System.IO;
using System.Text;

namespace Lowercase.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var fileStream = File.OpenRead(args[0]))
            {
                using (var reader = new StreamReader(fileStream, Encoding.ASCII, false))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        Console.WriteLine(CaseConverter.ToLowercase(line));
                    }
                }
            }
        }
    }

    public static class CaseConverter
    {
        public static string ToLowercase(string input)
        {
            return input.ToLower();
        }
    }
}
