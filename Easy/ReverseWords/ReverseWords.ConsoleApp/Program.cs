﻿using System;
using System.IO;
using System.Linq;

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
                    Console.WriteLine(StringProcessor.ReverseWords(line));
                }
        }
    }

    public static class StringProcessor
    {
        public static string ReverseWords(string sentence)
        {
            var words = sentence.Split();
            var result = words[words.Length - 1];

            for (var i = words.Length - 2; i >= 0; i--)
            {
                result = result + " " + words[i];
            }

            return result;
        }

        public static string ReverseWordsLINQ(string sentence)
        {
            return sentence.Split(' ').Reverse().Aggregate(
                (workingSentence, nextWord) => workingSentence + " " + nextWord);
        }
    }
}
