using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords.ConsoleApp
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
                    // do something with line
                }
        }
    }
}
