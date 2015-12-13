using System;
using System.IO;

namespace FileSize.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new FileInfo(args[0]).Length);
        }
    }
}
