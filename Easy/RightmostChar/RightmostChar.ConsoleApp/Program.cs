using System;
using System.IO;

namespace RightmostChar.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) { continue; }
                    Console.WriteLine(StringProcessor.RightmostChar(line));
                }
        }
    }

    public static class StringProcessor
    {
        public static int RightmostChar(string input)
        {
            return input.Remove(input.Length - 2).LastIndexOf(input[input.Length - 1]);
        }
    }
}
