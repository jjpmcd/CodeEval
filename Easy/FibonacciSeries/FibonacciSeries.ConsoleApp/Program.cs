using System;
using System.IO;

namespace FibonacciSeries.ConsoleApp
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
                    Console.WriteLine(FibonacciGenerator.GetNthNumber(line));
                }
        }
    }

    public static class FibonacciGenerator
    {
        public static int GetNthNumber(string input)
        {
            var n = int.Parse(input);
            
            if (n < 2) return n;

            var nMinus2 = 0;
            var nMinus1 = 1;

            var nth = 0;

            for (var i = 2; i <= n; i++)
            {
                nth = nMinus1 + nMinus2;
                nMinus2 = nMinus1;
                nMinus1 = nth;
            }

            return nth;
        }
    }
}
