using System;
using System.IO;
using System.Text;

namespace SimpleSorting.ConsoleApp
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
                        Console.WriteLine(Sorter.SimpleSort(line));
                    }
                }
            }
        }
    }

    public static class Sorter
    {
        public static string SimpleSort(string input)
        {
            // TODO: Just sort the string values, don't parse
            var splitInput = input.Split(' ');
            var parsedInput = new double[splitInput.Length];

            for (var i = 0; i < parsedInput.Length; i++)
            {
                parsedInput[i] = double.Parse(splitInput[i]);
            }

            Array.Sort(parsedInput);

            var builder = new StringBuilder(parsedInput[0].ToString("F3"));

            for (var i = 1; i < parsedInput.Length; i++)
            {
                builder.Append(' ');
                builder.Append(parsedInput[i].ToString("F3"));
            }

            return builder.ToString();
        }
    }
}
