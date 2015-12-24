using System;
using System.IO;
using System.Text;

namespace SwapCase.ConsoleApp
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
                        Console.WriteLine(Swapper.SwapCase(line));
                    }
                }
            }
        }
    }

    public static class Swapper
    {
        public static string SwapCase(string input)
        {
            var output = "";
            for (var i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    output += (char)(input[i] + 32);
                    continue;
                }
                if (char.IsLower(input[i]))
                {
                    output += (char)(input[i] - 32);
                    continue;
                }
                output += input[i];
            }

            return output;
        }
    }
}
