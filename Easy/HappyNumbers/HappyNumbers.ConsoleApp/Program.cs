using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HappyNumbers.ConsoleApp
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
                        Console.WriteLine(HappinessChecker.IsHappy(int.Parse(line)) ? "1" : "0");
                    }
                }
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
