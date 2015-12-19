using System;
using System.IO;
using System.Text;

namespace ArmstrongNumbers.ConsoleApp
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
                        Console.WriteLine(NumberParser.IsArmstrongNumber(line) ? "True" : "False");
                    }
                }
            }
        }
    }

    public static class NumberParser
    {
        public static bool IsArmstrongNumber(string input)
        {
            if (input.Length == 1) { return true; }

            var number = 0;
            var sum = 0;

            for (var i = 0; i < input.Length; i++)
            {
                number = 10 * number + (input[i] - 48);
                sum += MathPowFast(input[i] - 48, input.Length);
            }

            return number == sum;
        }

        private static int MathPowFast(int number, int power)
        {
            var result = 1;
            for (var i = 0; i < power; i++) { result *= number; }
            return result;
        }
    }
}
