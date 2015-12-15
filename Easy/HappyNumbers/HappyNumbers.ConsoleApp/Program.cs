using System;
using System.Collections.Generic;
using System.IO;

namespace HappyNumbers.ConsoleApp
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
                    Console.WriteLine(HappinessChecker.IsHappy(line));
                }
        }
    }

    public static class HappinessChecker
    {
        public static string IsHappy(string input)
        {
            var result = int.Parse(input);
            var previousResults = new List<int>();

            while (result != 1)
            {
                var dividend = result;
                byte divisor = 10;
                result = 0;
                while (dividend != 0)
                {
                    int remainder;
                    dividend = Math.DivRem(dividend, divisor, out remainder);
                    result += remainder * remainder;
                }
                if (previousResults.Contains(result)) { return "0"; }
                previousResults.Add(result);
            }

            return "1";
        }
    }
}
