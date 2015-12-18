using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FizzBuzz.ConsoleApp
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
                        Console.WriteLine(FizzBuzzer.GenerateSequence(line));
                    }
                }
            }
        }
    }

    public static class FizzBuzzer
    {
        public static string GenerateSequence(string input)
        {
            var numerals = input.Split(' ');
            var a = IntParseFast(numerals[0]);
            var b = IntParseFast(numerals[1]);
            var n = IntParseFast(numerals[2]);

            var builder = new StringBuilder();
            for (var index = 1; index < n + 1; index++)
            {
                var conversionPerformed = false;
                if (index % a == 0)
                {
                    builder.Append('F');
                    conversionPerformed = true;
                }
                if (index % b == 0)
                {
                    builder.Append('B');
                    conversionPerformed = true;
                }
                if (!conversionPerformed)
                {
                    builder.Append(index);
                }
                builder.Append(' ');
            }

            return builder.ToString(0, builder.Length - 1);
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
