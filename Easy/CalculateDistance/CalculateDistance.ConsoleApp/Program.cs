using System;
using System.IO;
using System.Text;

namespace CalculateDistance.ConsoleApp
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
                        Console.WriteLine(Calculator.GetDistance(line));
                    }
                }
            }
        }
    }

    public static class Calculator
    {
        public static int GetDistance(string input)
        {
            var coordinates = new int[4];
            var coordinatesIndex = 0;
            var startIndex = -1;
            var length = -1;
            for (var index = 0; index < input.Length; index++)
            {
                if (char.IsDigit(input[index]) || input[index] == '-')
                {
                    if (startIndex == -1)
                    {
                        startIndex = index;
                        length = 1;
                    }
                    else { length++; }
                }
                else
                {
                    if (startIndex == -1) continue;
                    coordinates[coordinatesIndex] = IntParseFast(input.Substring(startIndex, length));
                    coordinatesIndex++;
                    startIndex = -1;
                    length = -1;
                }
            }
            var diffX = coordinates[2] - coordinates[0];
            var diffY = coordinates[3] - coordinates[1];
            var distance = (int)Math.Sqrt(diffX * diffX + diffY * diffY);

            return distance;
        }

        private static int IntParseFast(string value)
        {
            var result = 0;
            var isNegative = value[0] == '-';
            for (var i = isNegative ? 1 : 0; i < value.Length; i++)
            {
                result = 10 * result + (value[i] - 48);
            }
            return isNegative ? result * -1 : result;
        }
    }
}
