using System;
using System.IO;
using System.Text;

namespace MixedContent.ConsoleApp
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
                        Console.WriteLine(Sorter.GetSeparatedLists(line));
                    }
                }
            }
        }
    }

    public static class Sorter
    {
        public static string GetSeparatedLists(string input)
        {
            string words = "";
            string digits = "";

            var splitInputs = input.Split(',');

            for (var index = 0; index < splitInputs.Length; index++)
            {
                if (char.IsDigit(splitInputs[index][0]))
                {
                    digits += splitInputs[index] + ',';
                }
                else
                {
                    words += splitInputs[index] + ',';
                }
            }

            if (words == "" || digits == "") return input;

            return words.Remove(words.Length - 1) + '|' + digits.Remove(digits.Length - 1);
        }
    }
}
