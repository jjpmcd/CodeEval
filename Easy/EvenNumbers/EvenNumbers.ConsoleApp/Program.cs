using System;
using System.IO;
using System.Text;

namespace EvenNumbers.ConsoleApp
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
                        Console.WriteLine(Checker.IsEven(line) ? "1" : "0");
                    }
                }
            }
        }
    }

    public static class Checker
    {
        public static bool IsEven(string input)
        {
            switch (input[input.Length - 1])
            {
                case '0':
                case '2':
                case '4':
                case '6':
                case '8':
                    return true;
            }
            return false;
        }
    }
}
