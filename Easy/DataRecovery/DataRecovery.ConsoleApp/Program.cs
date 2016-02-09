using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            var words = input.Substring(0, indexOfSemiColon).Split(' ');
            var indices = GetIndices(input.Substring(indexOfSemiColon + 1, input.Length - indexOfSemiColon - 1));

            var output = words[indices.IndexOf(1)];
            for (var position = 2; position < words.Length + 1; position++)
            {
                output += ' ';
                output += words[indices.IndexOf(position)];
            }

            return output;
        }

        private static List<int> GetIndices(string indicesString)
        {
            var indices = new List<int>();
            var runningParse = 0;
            var sum = 0;
            for (var index = 0; index < indicesString.Length; index++)
            {
                if (indicesString[index] == ' ')
                {
                    indices.Add(runningParse);
                    sum += runningParse;
                    runningParse = 0;
                    continue;
                }
                runningParse = 10 * runningParse + (indicesString[index] - 48);
            }
            indices.Add(runningParse);
            sum += runningParse;

            var length = indices.Count + 1;
            var missingIndex = length * (length + 1) / 2 - sum;

            indices.Add(missingIndex);
            return indices;
        }
    }
}
