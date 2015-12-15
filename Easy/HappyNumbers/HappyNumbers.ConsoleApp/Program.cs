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
                    Console.WriteLine(HappinessChecker.IsHappy(int.Parse(line)) ? "1" : "0");
                }
        }
    }

    public static class HappinessChecker
    {
        public static bool IsHappy(int result)
        {
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
                if (previousResults.Contains(result)) { return false; }
                previousResults.Add(result);
            }

            return true;
        }
    }
}
