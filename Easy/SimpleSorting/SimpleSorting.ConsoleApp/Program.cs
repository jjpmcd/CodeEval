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
            var splitInput = input.Split(' ');
            var parsedInput = new int[splitInput.Length];

            for (var i = 0; i < parsedInput.Length; i++)
            {
                parsedInput[i] = IntParseFast(splitInput[i]);
            }

            Array.Sort(parsedInput, splitInput);

            return string.Join(" ", splitInput);
        }

        private static int IntParseFast(string value)
        {
            var result = 0;
            var isNegative = value[0] == '-';
            for (var i = isNegative ? 1 : 0; i < value.Length; i++)
            {
                if(value[i] == '.') continue;
                result = 10 * result + (value[i] - 48);
            }
            return isNegative ? result * -1 : result;
        }
    }
}
