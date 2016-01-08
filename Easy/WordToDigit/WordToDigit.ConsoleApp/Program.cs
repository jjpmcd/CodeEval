using System;
using System.IO;
using System.Text;

namespace WordToDigit.ConsoleApp
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
                        Console.WriteLine(Parser.GetDigits(line));
                    }
                }
            }
        }
    }

    public static class Parser
    {
        public static string GetDigits(string input)
        {
            var output = "";
            var skip = false;

            for (var index = 0; index < input.Length; index++)
            {
                if (skip)
                {
                    if (input[index] == ';')
                    {
                        skip = false;
                    }
                    continue;
                }
                if (input[index] == 't')
                {
                    if (input[index + 1] == 'w')
                    {
                        output += '2';
                    }
                    else
                    {
                        output += '3';
                    }
                    skip = true;
                }
                else if (input[index] == 'f')
                {
                    if (input[index + 1] == 'o')
                    {
                        output += '4';
                    }
                    else
                    {
                        output += '5';
                    }
                    skip = true;
                }
                else if (input[index] == 's')
                {
                    if (input[index + 1] == 'i')
                    {
                        output += '6';
                    }
                    else
                    {
                        output += '7';
                    }
                    skip = true;
                }
                else if (input[index] == 'e')
                {
                    output += '8';
                    skip = true;
                }
                else if (input[index] == 'n')
                {
                    output += '9';
                    skip = true;
                }
                else if (input[index] == 'z')
                {
                    output += '0';
                    skip = true;
                }
                else if (input[index] == 'o')
                {
                    output += '1';
                    skip = true;
                }
            }

            return output;
        }
    }
}
