using System;
using System.IO;
using System.Text;

namespace LowestUniqueNumber.ConsoleApp
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
                        Console.WriteLine(NumberGame.GetLowestUnique(line));
                    }
                }
            }
        }
    }

    public static class NumberGame
    {
        public static int GetLowestUnique(string input)
        {
            var counts = new int[10];
            var chars = new char[(input.Length + 1) / 2];
            var charsIndex = 0;

            for (var index = 0; index < input.Length; index += 2)
            {
                counts[input[index] - 48]++;
                chars[charsIndex] = input[index];
                charsIndex++;
            }

            return FindLowestUnique(counts, chars);
        }

        private static int FindLowestUnique(int[] counts, char[] chars)
        {
            for (var i = 1; i < counts.Length; i++)
            {
                if (counts[i] != 1) continue;
                for (var j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == i + 48)
                    {
                        return j + 1;
                    }
                }
            }

            return 0;
        }
    }
}
