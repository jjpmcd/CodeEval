using System;
using System.IO;
using System.Text;

namespace LettercasePercentageRatio.ConsoleApp
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
                        Console.WriteLine(Scanner.GetLettercasePercentages(line));
                    }
                }
            }
        }
    }

    public static class Scanner
    {
        public static string GetLettercasePercentages(string input)
        {
            var lowerCount = 0;

            for (var index = 0; index < input.Length; index++)
            {
                if (char.IsLower(input[index])) lowerCount++;
            }

            var lowerPercentage = (double)lowerCount / input.Length * 100;
            var upperPercentage = 100 - lowerPercentage;

            return string.Format("lowercase: {0} uppercase: {1}", lowerPercentage.ToString("F2"), upperPercentage.ToString("F2"));
        }
    }
}
