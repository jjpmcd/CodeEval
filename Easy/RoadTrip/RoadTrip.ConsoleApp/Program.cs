﻿using System;
using System.IO;
using System.Text;

namespace RoadTrip.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var fileStream = File.OpenRead(args[0]))
            {
                using (var reader = new StreamReader(fileStream, Encoding.ASCII, false))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        Console.WriteLine(Calculator.GetDistances(line));
                    }
                }
            }
        }
    }

    public static class Calculator
    {
        public static string GetDistances(string input)
        {
            var distances = InitializeArray(input);
            var city = 0;
            var parsing = false;
            var workingValue = 0;

            for (var index = 0; index < input.Length; index++)
            {
                if (char.IsDigit(input[index]))
                {
                    parsing = true;
                    workingValue = 10 * workingValue + (input[index] - 48);
                    continue;
                }
                if (!parsing) continue;
                distances[city] = workingValue;
                city++;
                parsing = false;
                workingValue = 0;
            }

            Array.Sort(distances);

            return FormatOutput(distances);
        }

        private static string FormatOutput(int[] distances)
        {
            var output = distances[0].ToString();
            for (var index = 1; index < distances.Length; index++)
            {
                output += ',';
                output += distances[index] - distances[index - 1];
            }
            return output;
        }

        private static int[] InitializeArray(string input)
        {
            var numberOfElements = 0;
            for (var index = 0; index < input.Length; index++)
            {
                if (input[index] == ';') numberOfElements++;
            }
            return new int[numberOfElements];
        }
    }
}
