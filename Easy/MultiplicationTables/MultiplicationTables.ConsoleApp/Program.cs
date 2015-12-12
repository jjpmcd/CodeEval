using System;

namespace MultiplicationTables.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 12; i++)
            {
                Console.WriteLine(MultiplePrinter.PrintRow(i));
            }
        }
    }

    public static class MultiplePrinter
    {
        public static string PrintRow(int input)
        {
            const int max = 12;

            var count = 1;
            var current = input + input;
            var output = input.ToString();

            while (count < max)
            {
                output += string.Format("{0,4}", current);
                current += input;
                count++;
            }

            return output;
        }
    }
}
