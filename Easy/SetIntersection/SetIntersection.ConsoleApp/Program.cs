using System;
using System.IO;
using System.Text;

namespace SetIntersection.ConsoleApp
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
                        Console.WriteLine(SetComparer.GetIntersectingSet(line));
                    }
                }
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

            var result = "";
            var next = 0;
            foreach (var element in firstSplit)
            {
                for (var index = next; index < secondSplit.Length; index++)
                {
                    if (element != secondSplit[index]) { continue; }
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
