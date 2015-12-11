using System;
using System.IO;

namespace BitPositions.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line) continue;
                    Console.WriteLine(
                        BitChecker.AreEqualAtPositions(line) ? "true" : "false");
                }
        }
    }

    public static class BitChecker
    {
        public static bool AreEqualAtPositions(string input)
        {
            var splitInput = input.Split(',');
            var n = int.Parse(splitInput[0]);
            var p1 = int.Parse(splitInput[1]);
            var p2 = int.Parse(splitInput[2]);
            
            var mask1 = 1 << (p1 - 1);
            var mask2 = 1 << (p2 - 1);

            var bit1 = n & mask1;
            var bit2 = n & mask2;

            return (bit1 == 0 && bit2 == 0) || (bit1 != 0 && bit2 != 0);
        }
    }
}
