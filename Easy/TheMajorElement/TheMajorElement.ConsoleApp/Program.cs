using System;
using System.Collections.Generic;
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
            var splitInputs = input.Split(',');
            var frequencies = new Dictionary<string, int>();

            for (var index = 0; index < splitInputs.Length; index++)
            {
                if (!frequencies.ContainsKey(splitInputs[index]))
                {
                    frequencies.Add(splitInputs[index], 0);
                }

                frequencies[splitInputs[index]]++;

                if (frequencies[splitInputs[index]] > splitInputs.Length / 2)
                {
                    return splitInputs[index];
                }
            }

            return "None";
        }
    }
}
