using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BeautifulStrings.ConsoleApp
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
                        Console.WriteLine(Beautifier.GetMaxBeauty(line));
                    }
                }
            }
        }
    }

    public static class Beautifier
    {
        public static int GetMaxBeauty(string input)
        {
            var counts = new int[26];

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] > 64 && input[i] < 91)
                {
                    counts[input[i] - 65]++;
                    continue;
                }
                if (input[i] > 96 && input[i] < 123)
                {
                    counts[input[i] - 97]++;
                }
            }

            Array.Sort(counts);

            var score = 0;
            for (int i = counts.Length - 1; i >= 0; i--)
            {
                if (counts[i] == 0) { break; }
                score += counts[i] * (i + 1);
            }

            return score;
        }
    }
}