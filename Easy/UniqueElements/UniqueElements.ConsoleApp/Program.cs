using System;
using System.IO;
using System.Linq;

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
            var splitInput = input.Split(',');
            var output = splitInput.Distinct().Aggregate((workingString, nextElement) => workingString + ',' + nextElement);
            return output;
        }
    }
}
