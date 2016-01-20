using System;
using System.IO;
using System.Text;

namespace HiddenDigits.ConsoleApp
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
                        Console.WriteLine(Processor.GetAllDigits(line));
                    }
                }
            }
        }
    }

    public static class Processor
    {
        public static string GetAllDigits(string input)
        {
            string output = "";

            for (var index = 0; index < input.Length; index++)
            {
                if (char.IsDigit(input[index]))
                {
                    output += input[index];
                    continue;
                }

                if (input[index] > 96 && input[index] < 107)
                {
                    output += (char) (input[index] - 49);
                }
            }

            return output == "" ? "NONE" : output;
        }
    }
}
