using System;
using System.IO;

namespace SelfDescribingNumbers.ConsoleApp
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
                    Console.WriteLine(Numberifier.IsSelfDescribingNumber(line) ? "1" : "0");
                }
        }
    }

    public static class Numberifier
    {
        public static bool IsSelfDescribingNumber(string input)
        {
            var digitCounts = new byte[10];
            for (byte index = 0; index < input.Length; index++)
            {
                digitCounts[input[index] - 48]++;
            }

            for (byte index = 0; index < input.Length; index++)
            {
                if (input[index] - 48 != digitCounts[index]) { return false; }
            }

            return true;
        }
    }
}
