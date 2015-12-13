using System;

namespace OddNumbers.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 1; i < 100; i += 2) { Console.WriteLine(i); }
        }
    }
}
