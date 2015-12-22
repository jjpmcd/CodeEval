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
            if (input.IndexOf(' ') == -1) { return input; }
            var words = input.Split(' ');
            return words[words.Length - 2];
        }
    }
}
