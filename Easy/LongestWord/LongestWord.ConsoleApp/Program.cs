using System;
using System.IO;
using System.Text;

namespace LongestWord.ConsoleApp
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
                        Console.WriteLine(Parser.GetLongestWord(line));
                    }
                }
            }
        }
    }

    public static class Parser
    {
        public static string GetLongestWord(string input)
        {
            var splitInputs = input.Split(' ');
            var longestIndex = 0;
            var longestLength = 0;

            for (var index = 0; index < splitInputs.Length; index++)
            {
                if (splitInputs[index].Length > longestLength)
                {
                    longestLength = splitInputs[index].Length;
                    longestIndex = index;
                }
            }

            return splitInputs[longestIndex];
        }
    }
}
