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

        public static bool IsPrime(int number)
        {
            var isPrime = true;
            var upperBound = (int)Math.Sqrt(number) + 1;

            for (var i = 2; i < upperBound; i++)
            {
                if (number % i != 0) continue;
                isPrime = false;
                break;
            }

            return isPrime;
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
