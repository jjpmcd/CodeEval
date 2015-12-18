using System;
using System.IO;
using System.Text;

namespace ReverseWords.ConsoleApp
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
                        Console.WriteLine(StringProcessor.ReverseWords(line));
                    }
                }
            }
        }
    }

    public static class StringProcessor
    {
        public static string ReverseWords(string sentence)
        {
            var words = sentence.Split();
            var result = words[words.Length - 1];

            for (var i = words.Length - 2; i >= 0; i--)
            {
                result = result + " " + words[i];
            }

            return result;
        }
    }
}
