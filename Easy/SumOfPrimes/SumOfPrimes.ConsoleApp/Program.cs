using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfPrimes.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(PrimeProcessor.GetSumOfPrimes(1000));
        }
    }

    public static class PrimeProcessor
    {
        public static int GetSumOfPrimes(int limit)
        {
            int candidate = 3;
            int primesSum = 2;
            int primesCount = 1;
            while (primesCount < limit)
            {
                if (IsPrime(candidate))
                {
                    primesSum += candidate;
                    primesCount++;
                }
                candidate += 2;
            }
            return primesSum;
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
    }
}
