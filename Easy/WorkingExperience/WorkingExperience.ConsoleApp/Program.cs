using System;
using System.IO;
using System.Text;

namespace WorkingExperience.ConsoleApp
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
                        Console.WriteLine(Resumer.GetActualWorkExperience(line));
                    }
                }
            }
        }
    }

    public static class Resumer
    {
        public static int GetActualWorkExperience(string input)
        {
            var intervals = ParseIntervals(input);

            for (var i = 0; i < intervals.Length; i++)
            {
                for (var j = i + 1; j < intervals.Length; j++)
                {
                    if (intervals[i][1] < intervals[j][0]) continue;
                    if (intervals[i][0] > intervals[j][1]) continue;
                    intervals[j][0] = Math.Min(intervals[i][0], intervals[j][0]);
                    intervals[j][1] = Math.Max(intervals[i][1], intervals[j][1]);
                    intervals[i][0] = -1;
                    break;
                }
            }

            var totalMonths = 0;
            for (var index = 0; index < intervals.Length; index++)
            {
                if (intervals[index][0] == -1) continue;
                totalMonths += intervals[index][1] - intervals[index][0];
            }

            return totalMonths / 12;
        }

        private static int[][] ParseIntervals(string input)
        {
            var elements = 1;
            for (var index = 0; index < input.Length; index++)
                if (input[index] == ';') elements++;

            var months = 0;
            var interval = 0;
            var intervals = new int[elements][];
            intervals[interval] = new int[2];
            for (var index = 0; index < input.Length; index++)
            {
                switch (input[index])
                {
                    case ' ':
                        months += ParseMonth(input, index);
                        continue;
                    case '-':
                        months += ParseYearToMonths(input, index);
                        intervals[interval][0] = months;
                        months = 0;
                        continue;
                    case ';':
                        months += ParseYearToMonths(input, index) + 1;
                        intervals[interval][1] = months;
                        months = 0;
                        interval++;
                        intervals[interval] = new int[2];
                        index++;
                        break;
                }
            }

            months += ParseYearToMonths(input, input.Length) + 1;
            intervals[interval][1] = months;

            return intervals;
        }

        private static int ParseYearToMonths(string input, int index)
        {
            var result = 0;

            for (var i = index - 4; i < index; i++)
            {
                result = 10 * result + (input[i] - 48);
            }
            result -= 1990;
            result *= 12;

            return result;
        }

        private static int ParseMonth(string input, int index)
        {
            switch (input[index - 3])
            {
                case 'J':
                    if (input[index - 2] == 'a') return 1;
                    return input[index - 1] == 'n' ? 6 : 7;
                case 'M':
                    return input[index - 1] == 'r' ? 3 : 5;
                case 'A':
                    return input[index - 2] == 'p' ? 4 : 8;
                case 'F':
                    return 2;
                case 'S':
                    return 9;
                case 'O':
                    return 10;
                case 'N':
                    return 11;
                case 'D':
                    return 12;
                default:
                    return 0;
            }
        }
    }
}
