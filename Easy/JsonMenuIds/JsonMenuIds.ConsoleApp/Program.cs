using System;
using System.IO;
using System.Text;

namespace JsonMenuIds.ConsoleApp
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
                        Console.WriteLine(JsonParser.GetSum(line));
                    }
                }
            }
        }
    }

    public static class JsonParser
    {
        public static int GetSum(string input)
        {
            char[] prefix = { 'L', 'a', 'b', 'e', 'l', ' ' };
            var sum = 0;
            var matched = 0;
            var startIndex = 0;
            var length = 0;

            for (var index = 0; index < input.Length; index++)
            {
                if (matched == prefix.Length)
                {
                    if (length == 0) startIndex = index;

                    if (char.IsDigit(input[index]))
                    {
                        length++;
                        continue;
                    }

                    sum += IntParseFast(input.Substring(startIndex, length));
                    length = 0;
                    matched = 0;
                }

                if (input[index] == prefix[matched]) matched++;
            }

            return sum;
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
