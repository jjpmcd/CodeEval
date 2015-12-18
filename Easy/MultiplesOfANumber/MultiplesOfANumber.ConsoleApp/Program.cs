using System;
using System.IO;
using System.Text;

namespace MultiplesOfANumber.ConsoleApp
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
                        Console.WriteLine(MultipleProcessor.FindSmallestMultiple(line));
                    }
                }
            }
        }
    }

    public static class MultipleProcessor
    {
        public static int FindSmallestMultiple(string input)
        {
            var splitInput = input.Split(',');
            var x = int.Parse(splitInput[0]);
            var n = int.Parse(splitInput[1]);

            var result = n;
            while (x > result) result += n;

            return result;
        }
    }
}
