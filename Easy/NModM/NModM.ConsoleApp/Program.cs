using System;
using System.IO;

namespace NModM.ConsoleApp
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
                    Console.WriteLine(Calculator.GetRemainder(line));
                }
        }
    }

    public static class Calculator
    {
        public static int GetRemainder(string input)
        {
            var splitInput = input.Split(',');
            var dividend = int.Parse(splitInput[0]);
            var divisor = int.Parse(splitInput[1]);

            while (dividend >= divisor) { dividend -= divisor; }

            return dividend;
        }
    }
}
