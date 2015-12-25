using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenNumbers.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = File.OpenRead(args[0]))
            {
                using (var reader = new StreamReader(fileStream, Encoding.ASCII, false))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        // Do something with line                   
                    }
                }
            }
        }
    }
}
