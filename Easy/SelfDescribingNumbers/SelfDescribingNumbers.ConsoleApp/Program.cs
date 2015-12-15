﻿using System;
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
            foreach (var digit in input) { digitCounts[CharToInt(digit)]++; }

            for (var index = 0; index < input.Length; index++)
            {
                var number = CharToInt(input[index]);
                if (number != digitCounts[index]) { return false; }
            }

            return true;
        }

        private static int CharToInt(char numeral)
        {
            switch (numeral)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
