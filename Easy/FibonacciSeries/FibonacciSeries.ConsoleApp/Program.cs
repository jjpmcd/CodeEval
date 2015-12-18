using System;
using System.IO;
using System.Text;

namespace FibonacciSeries.ConsoleApp
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
                        Console.WriteLine(FibonacciGenerator.GetNthNumber(line));
                    }
                }
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
