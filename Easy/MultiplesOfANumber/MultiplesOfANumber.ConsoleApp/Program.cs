using System;
using System.IO;

namespace MultiplesOfANumber.ConsoleApp
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
                    Console.WriteLine(MultipleProcessor.FindSmallestMultiple(line));
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

            var result = FindSmallestMultipleUsingAddition(x, n);

            return result;
        }

        private static int FindSmallestMultipleUsingAddition(int x, int n)
        {
            var result = n;
            while (x > result) result += n;
            return result;
        }
    }
}
