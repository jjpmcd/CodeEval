using System;
using System.IO;
using System.Text;

namespace SumOfDigits.ConsoleApp
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
                        Console.WriteLine(DigitProcessor.SumOfDigits(line));
                    }
                }
            }
        }
    }

    public static class DigitProcessor
    {
        public static int SumOfDigits(string input)
        {
            var dividend = int.Parse(input);
            byte divisor = 10;
            var sum = 0;

            while (dividend > 0)
            {
                int remainder;
                dividend = Math.DivRem(dividend, divisor, out remainder);
                sum += remainder;
            }

            return sum;
        }
    }
}
