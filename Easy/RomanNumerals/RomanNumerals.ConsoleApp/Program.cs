using System;
using System.IO;
using System.Text;

namespace RomanNumerals.ConsoleApp
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
                        Console.WriteLine(Converter.ToRomanNumerals(line));
                    }
                }
            }
        }
    }

    public static class Converter
    {
        public static string ToRomanNumerals(string decimalAsString)
        {
            var min = 'I';
            var mid = 'V';
            var max = 'X';
            var builder = new StringBuilder();

            for (var i = 1; i <= decimalAsString.Length; i++)
            {
                switch (i)
                {
                    case 2:
                        min = 'X';
                        mid = 'L';
                        max = 'C';
                        break;
                    case 3:
                        min = 'C';
                        mid = 'D';
                        max = 'M';
                        break;
                    case 4:
                        min = 'M';
                        break;
                }

                switch (decimalAsString[decimalAsString.Length - i])
                {
                    case '9':
                        builder.Insert(0, max);
                        builder.Insert(0, min);
                        break;
                    case '8':
                        builder.Insert(0, min);
                        builder.Insert(0, min);
                        builder.Insert(0, min);
                        builder.Insert(0, mid);
                        break;
                    case '7':
                        builder.Insert(0, min);
                        builder.Insert(0, min);
                        builder.Insert(0, mid);
                        break;
                    case '6':
                        builder.Insert(0, min);
                        builder.Insert(0, mid);
                        break;
                    case '5':
                        builder.Insert(0, mid);
                        break;
                    case '4':
                        builder.Insert(0, mid);
                        builder.Insert(0, min);
                        break;
                    case '3':
                        builder.Insert(0, min);
                        builder.Insert(0, min);
                        builder.Insert(0, min);
                        break;
                    case '2':
                        builder.Insert(0, min);
                        builder.Insert(0, min);
                        break;
                    case '1':
                        builder.Insert(0, min);
                        break;
                }
            }
            return builder.ToString();
        }
    }
}
