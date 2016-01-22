using System;
using System.IO;
using System.Text;

namespace CompressedSequence.ConsoleApp
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
                        Console.WriteLine(Dictator.GetCompressedSequence(line));
                    }
                }
            }
        }
    }

    public static class Dictator
    {
        public static string GetCompressedSequence(string input)
        {
            var splitInputs = input.Split(' ');

            var count = 1;
            var output = "";

            for (var index = 1; index < splitInputs.Length; index++)
            {
                if (splitInputs[index] == splitInputs[index - 1])
                {
                    count++;
                    continue;
                }

                output += count;
                output += ' ';
                output += splitInputs[index - 1];
                output += ' ';

                count = 1;
            }

            output += count;
            output += ' ';
            output += splitInputs[splitInputs.Length - 1];

            return output;
        }
    }
}
