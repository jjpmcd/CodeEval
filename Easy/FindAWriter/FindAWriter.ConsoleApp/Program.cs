using System;
using System.IO;
using System.Text;

namespace FindAWriter.ConsoleApp
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
                        Console.WriteLine(CodeCracker.GetWriter(line));
                    }
                }
            }
        }
    }

    public static class CodeCracker
    {
        public static string GetWriter(string input)
        {
            var indexOfPipe = input.IndexOf('|');
            var encodedMessage = input.Substring(0, indexOfPipe);
            var positions = input.Substring(indexOfPipe + 1).Split(' ');
            var output = new StringBuilder();

            for (var index = 1; index < positions.Length; index++)
            {
                output.Append(encodedMessage[IntParseFast(positions[index]) - 1]);
            }

            return output.ToString();
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
