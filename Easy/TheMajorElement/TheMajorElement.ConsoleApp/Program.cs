using System;
using System.IO;
using System.Text;

namespace TheMajorElement.ConsoleApp
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
                        Console.WriteLine(Sequencer.GetMajorElement(line));
                    }
                }
            }
        }
    }

    public static class Sequencer
    {
        public static string GetMajorElement(string input)
        {
            var majorThreshold = GetNumberOfElements(input) / 2;
            var frequencies = new int[101];
            var runningParse = 0;

            for (var index = 0; index < input.Length; index++)
            {
                if (input[index] == ',')
                {
                    frequencies[runningParse]++;
                    if (frequencies[runningParse] > majorThreshold)
                        return runningParse.ToString();
                    runningParse = 0;
                    continue;
                }
                runningParse = 10 * runningParse + (input[index] - 48);
            }

            return "None";
        }

        private static int GetNumberOfElements(string input)
        {
            var numberOfElements = -1;
            for (var index = 0; index < input.Length; index++)
                if (input[index] == ',') numberOfElements++;
            return numberOfElements;
        }
    }
}
