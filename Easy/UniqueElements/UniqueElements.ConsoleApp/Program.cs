using System;
using System.IO;

namespace UniqueElements.ConsoleApp
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
                    Console.WriteLine(StringProcessor.GetUniqueElements(line));
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
