using System;
using System.IO;
using System.Linq;
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
                        Console.WriteLine(StringManipulator.RemoveCharacters(line));
                    }
                }
            }
        }
    }

    public static class StringManipulator
    {
        public static string RemoveCharacters(string input)
        {
            var splitInput = input.Split(new[] { ", " }, StringSplitOptions.None);
            return ScrubCharactersFromString(targetString: splitInput[0], charactersToScrub: splitInput[1]);
        }

        private static string ScrubCharactersFromString(string targetString, string charactersToScrub)
        {
            var builder = new StringBuilder(targetString);
            for (var targetIndex = 0; targetIndex < builder.Length; targetIndex++)
            {
                if (charactersToScrub.All(t => builder[targetIndex] != t)) continue;
                builder.Remove(targetIndex, 1);
                targetIndex--;
            }
            return builder.ToString();
        }
    }
}
