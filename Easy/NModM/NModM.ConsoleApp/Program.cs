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
            var dividend = IntParseFast(splitInput[0]);
            var divisor = IntParseFast(splitInput[1]);

            while (dividend >= divisor) { dividend -= divisor; }

            return dividend;
        }

        private static int IntParseFast(string value)
        {
            var result = 0;

            for (var i = 0; i < value.Length; i++)
            {
                result = 10 * result + (value[i] - 48);
            }

            return result;
        }
    }
}
