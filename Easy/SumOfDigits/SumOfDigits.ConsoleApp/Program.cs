using System;
using System.IO;

namespace SumOfDigits.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line) continue;
                    Console.WriteLine(DigitProcessor.SumOfDigits(line));
                }
        }
    }

    public static class DigitProcessor
    {
        public static int SumOfDigits(string input)
        {
            var dividend = int.Parse(input);
            const int divisor = 10;
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
