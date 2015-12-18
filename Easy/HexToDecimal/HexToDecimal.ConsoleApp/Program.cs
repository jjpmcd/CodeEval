using System;
using System.IO;
using System.Text;

namespace HexToDecimal.ConsoleApp
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
                        Console.WriteLine(BaseConverter.HexToDecimal(line));
                    }
                }
            }
        }
    }

    public static class BaseConverter
    {
        public static int HexToDecimal(string input)
        {
            int result = HexDigitToDecimal(input[input.Length - 1]);
            if (input.Length == 1) { return result; }
            var factor = 16;
            for (var index = input.Length - 2; index >= 0; index--)
            {
                result += HexDigitToDecimal(input[index]) * factor;
                if (index == 0) break;
                factor *= 16;
            }
            return result;
        }

        private static byte HexDigitToDecimal(char digit)
        {
            switch (digit)
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
                case 'a':
                    return 10;
                case 'b':
                    return 11;
                case 'c':
                    return 12;
                case 'd':
                    return 13;
                case 'e':
                    return 14;
                case 'f':
                    return 15;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
