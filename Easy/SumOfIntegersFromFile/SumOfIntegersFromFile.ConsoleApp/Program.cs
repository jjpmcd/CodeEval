using System;
using System.IO;
using System.Text;

namespace SumOfIntegersFromFile.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var total = 0;
            using (var fileStream = File.OpenRead(args[0]))
            {
                using (var reader = new StreamReader(fileStream, Encoding.ASCII, false))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        if (null == line) continue;
                        total += int.Parse(line);
                    }
                    Console.WriteLine(total);
                }
            }
        }
    }
}
