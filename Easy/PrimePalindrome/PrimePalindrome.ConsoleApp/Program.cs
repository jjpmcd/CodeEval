using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePalindrome.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(NumberProcessor.FindLargestPrimePalindrome(1000));
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

        public static bool IsPrime(int candidate)
        {
            if (candidate <= 3)
            {
                return candidate > 1;
            }
            if (candidate % 3 == 0 || candidate % 2 == 0)
            {
                return false;
            }
            for (var index = 5; index < (int)Math.Sqrt(candidate) + 1; index += 6)
            {
                if (candidate % index == 0 || candidate % (index + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int FindLargestPrimePalindrome(int upperBound)
        {
            for (var candidate = upperBound - 1; candidate > 1; candidate--)
            {
                if (IsPalindrome(candidate) && IsPrime(candidate))
                {
                    return candidate;
                }
            }

            return -1;
        }
    }
}
