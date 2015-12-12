using System;
using System.IO;

namespace Lowercase.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line) continue;
                    Console.WriteLine(CaseConverter.ToLowercase(line));
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
