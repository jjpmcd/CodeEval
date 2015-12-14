using System;
using System.IO;
using System.Linq;

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
            var firstSet = splitInput[0].Split(',');
            var secondSet = splitInput[1].Split(',');
            var intersectingSet = firstSet.Intersect(secondSet).ToArray();
            return intersectingSet.Length == 0 ? "" : intersectingSet.Aggregate((workingString, nextElement) => workingString + ',' + nextElement);
        }
    }
}
