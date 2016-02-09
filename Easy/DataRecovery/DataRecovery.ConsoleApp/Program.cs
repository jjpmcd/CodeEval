using System;
using System.IO;
using System.Text;

namespace DataRecovery.ConsoleApp
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
                        Console.WriteLine(Reconstructor.GetSentence(line));
                    }
                }
            }
        }
    }

    public static class Reconstructor
    {
        public static string GetSentence(string input)
        {
            var indexOfSemiColon = input.IndexOf(';');
            var scrambled = input.Substring(0, indexOfSemiColon).Split(' ');
            var length = scrambled.Length;

            var indices = CalculateIndices(length, input.Substring(indexOfSemiColon + 1, input.Length - indexOfSemiColon - 1));

            var unscrambled = new string[scrambled.Length];

            for (var index = 0; index < scrambled.Length; index++)
                unscrambled[indices[index] - 1] = scrambled[index];

            return string.Join(" ", unscrambled);
        }

        private static int[] CalculateIndices(int length, string indicesString)
        {
            var indices = new int[length];
            var runningParse = 0;
            var sum = 0;
            var count = 0;
            for (var index = 0; index < indicesString.Length; index++)
            {
                if (indicesString[index] == ' ')
                {
                    indices[count] = runningParse;
                    sum += runningParse;
                    runningParse = 0;
                    count++;
                    continue;
                }
                runningParse = 10 * runningParse + (indicesString[index] - 48);
            }
            indices[count] = runningParse;
            sum += runningParse;
            indices[count + 1] = length * (length + 1) / 2 - sum;
            return indices;
        }
    }
}
