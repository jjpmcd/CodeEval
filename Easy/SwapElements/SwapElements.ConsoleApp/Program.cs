using System;
using System.IO;
using System.Text;

namespace SwapElements.ConsoleApp
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
                        Console.WriteLine(Swapper.GetSwapped(line));
                    }
                }
            }
        }
    }

    public static class Swapper
    {
        public static string GetSwapped(string input)
        {
            var indexOfColon = input.IndexOf(':');
            var elements = input.Substring(0, indexOfColon - 1).Split(' ');

            ParseInstructions(input, indexOfColon, elements);

            return string.Join(" ", elements);
        }

        private static void ParseInstructions(string input, int indexOfColon, string[] elements)
        {
            var index = indexOfColon + 2;
            var firstIndex = 0;
            var secondIndex = 0;
            var first = true;

            while (index < input.Length)
            {
                if (input[index] == '-')
                {
                    first = false;
                    index++;
                    continue;
                }

                if (input[index] == ',')
                {
                    Swap(elements, firstIndex, secondIndex);

                    first = true;
                    firstIndex = 0;
                    secondIndex = 0;
                    index += 2;
                    continue;
                }

                if (first)
                {
                    firstIndex = CumulativeIntFastParse(input[index], firstIndex);
                }
                else
                {
                    secondIndex = CumulativeIntFastParse(input[index], secondIndex);

                    if (index == input.Length - 1)
                    {
                        Swap(elements, firstIndex, secondIndex);
                        break;
                    }
                }

                index++;
            }
        }

        private static int CumulativeIntFastParse(char c, int total)
        {
            total = 10 * total + (c - 48);
            return total;
        }

        private static void Swap(string[] elements, int firstIndex, int secondIndex)
        {
            var temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }
    }
}
