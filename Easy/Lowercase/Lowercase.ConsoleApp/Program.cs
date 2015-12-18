using System;
using System.IO;
using System.Text;

namespace Lowercase.ConsoleApp
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
                        Console.WriteLine(CaseConverter.ToLowercase(line));
                    }
                }
            }
        }
    }

    public static class CaseConverter
    {
        public static string ToLowercase(string input)
        {
            var chars = new char[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                var candidate = input[i];
                switch (candidate)
                {
                    case 'A':
                        candidate = 'a';
                        break;
                    case 'B':
                        candidate = 'b';
                        break;
                    case 'C':
                        candidate = 'c';
                        break;
                    case 'D':
                        candidate = 'd';
                        break;
                    case 'E':
                        candidate = 'e';
                        break;
                    case 'F':
                        candidate = 'f';
                        break;
                    case 'G':
                        candidate = 'g';
                        break;
                    case 'H':
                        candidate = 'h';
                        break;
                    case 'I':
                        candidate = 'i';
                        break;
                    case 'J':
                        candidate = 'j';
                        break;
                    case 'K':
                        candidate = 'k';
                        break;
                    case 'L':
                        candidate = 'l';
                        break;
                    case 'M':
                        candidate = 'm';
                        break;
                    case 'N':
                        candidate = 'n';
                        break;
                    case 'O':
                        candidate = 'o';
                        break;
                    case 'P':
                        candidate = 'p';
                        break;
                    case 'Q':
                        candidate = 'q';
                        break;
                    case 'R':
                        candidate = 'r';
                        break;
                    case 'S':
                        candidate = 's';
                        break;
                    case 'T':
                        candidate = 't';
                        break;
                    case 'U':
                        candidate = 'u';
                        break;
                    case 'V':
                        candidate = 'v';
                        break;
                    case 'W':
                        candidate = 'w';
                        break;
                    case 'X':
                        candidate = 'x';
                        break;
                    case 'Y':
                        candidate = 'y';
                        break;
                    case 'Z':
                        candidate = 'z';
                        break;
                }
                chars[i] = candidate;
            }
            return new string(chars);
        }
    }
}
