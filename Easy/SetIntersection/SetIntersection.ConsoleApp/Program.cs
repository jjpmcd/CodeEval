using System;
using System.IO;

namespace SetIntersection.ConsoleApp
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
                    Console.WriteLine(SetComparer.GetIntersectingSet(line));
                }
        }
    }

    public static class SetComparer
    {
        public static string GetIntersectingSet(string input)
        {
            var splitInput = input.Split(';');
            var firstSplit = splitInput[0].Split(',');
            var secondSplit = splitInput[1].Split(',');

            var firstSet = new int[firstSplit.Length];
            var secondSet = new int[secondSplit.Length];

            for (var index = 0; index < firstSplit.Length; index++)
            {
                firstSet[index] = int.Parse(firstSplit[index]);
            }

            for (var index = 0; index < secondSplit.Length; index++)
            {
                secondSet[index] = int.Parse(secondSplit[index]);
            }

            var result = "";
            var next = 0;
            foreach (var element in firstSet)
            {
                for (var index = next; index < secondSet.Length; index++)
                {
                    if (element < secondSet[index])
                    {
                        next = index;
                        break;
                    }
                    if (element != secondSet[index]) { continue; }
                    if (result != "") { result += ','; }
                    result += element;
                    next = index + 1;
                    break;
                }
            }

            return result;
        }
    }
}
