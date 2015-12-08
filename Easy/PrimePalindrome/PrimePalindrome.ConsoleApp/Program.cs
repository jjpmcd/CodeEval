using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePalindrome.ConsoleApp
{
    class Program
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

    public static class NumberProcessor
    {
        public static bool IsPalindrome(int number)
        {
            var isPalindrome = true;
            var numberString = number.ToString();
            var upperBound = numberString.Length / 2 + 1;

            for (var index = 0; index < upperBound; index++)
            {
                if (numberString[index] == numberString[numberString.Length - 1 - index]) continue;
                isPalindrome = false;
                break;
            }

            return isPalindrome;
        }
    }
}
