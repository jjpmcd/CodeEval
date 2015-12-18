using System;
using System.IO;
using System.Text;

namespace UniqueElements.ConsoleApp
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
                        Console.WriteLine(StringProcessor.GetUniqueElements(line));
                    }
                }
            }
        }
    }

    public static class StringProcessor
    {
        public static string GetUniqueElements(string input)
        {
            var result = "";
            var current = "";
            var previous = "";

            foreach (var c in input)
            {
                if (c != ',')
                {
                    current += c;
                    continue;
                }

                if (current != previous)
                {
                    if (result != "")
                    {
                        result += ',';
                    }
                    result += current;
                    previous = current;
                }
                current = "";
            }

            if (current != previous)
            {
                result += ',' + current;
            }

            return result;
        }
    }
}
