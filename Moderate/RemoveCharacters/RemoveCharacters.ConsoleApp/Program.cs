using System;
using System.IO;
using System.Text;

namespace RemoveCharacters.ConsoleApp
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
                        Console.WriteLine(Scrubber.RemoveCharacters(line));
                    }
                }
            }
        }
    }

    public static class Scrubber
    {
        public static string RemoveCharacters(string input)
        {
            var indexOfComma = input.IndexOf(',');
            var target = input.Substring(0, indexOfComma);
            var chars = input.Substring(indexOfComma + 2);
            return ScrubCharactersFromString(target, chars);
        }

        private static string ScrubCharactersFromString(string target, string chars)
        {
            var scrubbed = "";
            for (var targetIndex = 0; targetIndex < target.Length; targetIndex++)
            {
                var matched = false;
                for (var charsIndex = 0; charsIndex < chars.Length; charsIndex++)
                {
                    if (target[targetIndex] != chars[charsIndex]) continue;
                    matched = true;
                    break;
                }
                if (!matched) scrubbed += target[targetIndex];
            }
            return scrubbed;
        }
    }
}
