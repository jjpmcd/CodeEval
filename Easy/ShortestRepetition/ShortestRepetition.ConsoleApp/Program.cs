using System;
using System.IO;
using System.Text;

namespace ShortestRepetition.ConsoleApp
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
                        Console.WriteLine(Scanner.GetSmallestPeriod(line));
                    }
                }
            }
        }
    }

    public static class Scanner
    {
        public static int GetSmallestPeriod(string input)
        {
            for (var index = 1; index < input.Length; index++)
            {
                if (input[0] == input[index]) return index;
            }
            return input.Length;
        }
    }
}
