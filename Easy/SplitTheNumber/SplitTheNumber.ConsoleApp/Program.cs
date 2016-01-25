using System;
using System.IO;
using System.Text;

namespace SplitTheNumber.ConsoleApp
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
                        Console.WriteLine(Processor.GetSplitNumber(line));
                    }
                }
            }
        }
    }

    public static class Processor
    {
        public static int GetSplitNumber(string input)
        {
            var indexOfSpace = input.IndexOf(' ');
            var runningParse = 0;
            var firstNumber = 0;
            var subtract = false;
            for (var index = 0; index < indexOfSpace; index++)
            {
                if (input[indexOfSpace + 1 + index] == '+' || 
                    input[indexOfSpace + 1 + index] == '-')
                {
                    firstNumber = runningParse;
                    runningParse = 0;
                    subtract = input[indexOfSpace + 1 + index] == '-';
                }

                runningParse = 10 * runningParse + (input[index] - 48);
            }

            return subtract ? firstNumber - runningParse : firstNumber + runningParse;
        }
    }
}
