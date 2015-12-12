using System;
using System.IO;

namespace SumOfIntegersFromFile.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var total = 0;
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line) continue;
                    total += int.Parse(line);
                }
            Console.WriteLine(total);
        }
    }
}
