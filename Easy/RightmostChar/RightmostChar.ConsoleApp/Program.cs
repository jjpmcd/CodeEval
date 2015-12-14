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
            for (var i = input.Length - 3; i >= 0; i--)
            {
                if (input[i] == input[input.Length - 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
