using System;
using System.IO;
using System.Text;

namespace SelfDescribingNumbers.ConsoleApp
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
                        Console.WriteLine(Numberifier.IsSelfDescribingNumber(line));
                    }
                }
            }
        }
    }

    public static class Numberifier
    {
        public static char IsSelfDescribingNumber(string input)
        {
            var digitCounts = new byte[10];
            for (byte index = 0; index < input.Length; index++)
            {
                digitCounts[input[index] - 48]++;
            }

            for (byte index = 0; index < input.Length; index++)
            {
                if (input[index] - 48 != digitCounts[index]) { return '0'; }
            }

            return '1';
        }
    }
}
