using System;
using System.IO;
using System.Text;

namespace MultiplyLists.ConsoleApp
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
                        Console.WriteLine(Calculator.MultiplyLists(line));
                    }
                }
            }
        }
    }

    public static class Calculator
    {
        public static string MultiplyLists(string input)
        {
            var indexOfBar = input.IndexOf('|');
            var arrayOne = input.Substring(0, indexOfBar - 1).Split(' ');
            var arrayTwo = input.Substring(indexOfBar + 2).Split(' ');

            var result = (IntParseFast(arrayOne[0]) * IntParseFast(arrayTwo[0])).ToString();

            for (var index = 1; index < arrayOne.Length; index++)
            {
                result += ' ';
                result += (IntParseFast(arrayOne[index]) * IntParseFast(arrayTwo[index])).ToString();
            }

            return result;
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
