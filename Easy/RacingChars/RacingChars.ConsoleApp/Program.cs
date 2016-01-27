using System;
using System.IO;
using System.Text;

namespace RacingChars.ConsoleApp
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
                        Console.WriteLine(Racer.GetNextManoeuvre(line));
                    }
                }
            }
        }
    }

    public static class Racer
    {
        public static int IndexOfPreviousManoeuvre = -1;
        private static readonly char[] Manoeuvres = { '/', '|', '\\' };

        public static string GetNextManoeuvre(string input)
        {
            var indexOfNextManoeuvre = GetIndexOfNextManoeuvre(input);
            var output = GetOutputString(input, indexOfNextManoeuvre);
            IndexOfPreviousManoeuvre = indexOfNextManoeuvre;
            return output;
        }

        private static string GetOutputString(string input, int indexOfNextManoeuvre)
        {
            var output = new char[input.Length];
            for (var index = 0; index < input.Length; index++)
            {
                if (index == indexOfNextManoeuvre)
                {
                    if (IndexOfPreviousManoeuvre == -1)
                    {
                        output[index] = Manoeuvres[1];
                        continue;
                    }

                    output[index] = Manoeuvres[1 + indexOfNextManoeuvre - IndexOfPreviousManoeuvre];
                    continue;
                }

                output[index] = input[index];
            }

            return new string(output);
        }

        private static int GetIndexOfNextManoeuvre(string input)
        {
            if (IndexOfPreviousManoeuvre == -1) return input.IndexOf('_');

            var indexOfBestManoeuvre = -1;

            for (var index = Math.Max(0, IndexOfPreviousManoeuvre - 1);
                index < Math.Min(IndexOfPreviousManoeuvre + 2, input.Length);
                index++)
            {
                if (input[index] == 'C')
                {
                    indexOfBestManoeuvre = index;
                    break;
                }

                if (input[index] == '_') indexOfBestManoeuvre = index;
            }

            return indexOfBestManoeuvre;
        }
    }
}
