using System;
using System.IO;
using System.Text;

namespace PenultimateWord.ConsoleApp
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
                        Console.WriteLine(Scanner.GetPenultimateWord(line));
                    }
                }
            }
        }
    }

    public static class Scanner
    {
        public static string GetPenultimateWord(string input)
        {
            var startSpaceIndex = -1;
            var endSpaceIndex = -1;
            for (var index = input.Length - 1; index >= 0; index--)
            {
                if (input[index] != ' ') continue;
                if (endSpaceIndex == -1)
                {
                    endSpaceIndex = index;
                }
                else
                {
                    startSpaceIndex = index;
                    break;
                }
            }

            if (endSpaceIndex == -1) return input;

            return startSpaceIndex == -1 ? input.Substring(0, endSpaceIndex) : input.Substring(startSpaceIndex + 1, endSpaceIndex - startSpaceIndex - 1);
        }
    }
}
