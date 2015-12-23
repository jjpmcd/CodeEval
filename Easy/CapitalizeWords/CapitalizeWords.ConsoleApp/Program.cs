using System;
using System.IO;
using System.Text;

namespace CapitalizeWords.ConsoleApp
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
                        Console.WriteLine(Caser.ToTitleCase(line));               
                    }
                }
            }
        }
    }

    public static class Caser
    {
        public static string ToTitleCase(string input)
        {
            var output = "";
            var capitilize = true;
            for (var index = 0; index < input.Length; index++)
            {
                if (capitilize)
                {
                    output += Capitalize(input[index]);
                    capitilize = false;
                    continue;
                }

                if (input[index] == ' ') { capitilize = true; }

                output += input[index];
            }

            return output;
        }

        private static char Capitalize(char candidate)
        {
            switch (candidate)
            {
                case 'a':
                    candidate = 'A';
                    break;
                case 'b':
                    candidate = 'B';
                    break;
                case 'c':
                    candidate = 'C';
                    break;
                case 'd':
                    candidate = 'D';
                    break;
                case 'e':
                    candidate = 'E';
                    break;
                case 'f':
                    candidate = 'F';
                    break;
                case 'g':
                    candidate = 'G';
                    break;
                case 'h':
                    candidate = 'H';
                    break;
                case 'i':
                    candidate = 'I';
                    break;
                case 'j':
                    candidate = 'J';
                    break;
                case 'k':
                    candidate = 'K';
                    break;
                case 'l':
                    candidate = 'L';
                    break;
                case 'm':
                    candidate = 'M';
                    break;
                case 'n':
                    candidate = 'N';
                    break;
                case 'o':
                    candidate = 'O';
                    break;
                case 'p':
                    candidate = 'P';
                    break;
                case 'q':
                    candidate = 'Q';
                    break;
                case 'r':
                    candidate = 'R';
                    break;
                case 's':
                    candidate = 'S';
                    break;
                case 't':
                    candidate = 'T';
                    break;
                case 'u':
                    candidate = 'U';
                    break;
                case 'v':
                    candidate = 'V';
                    break;
                case 'w':
                    candidate = 'W';
                    break;
                case 'x':
                    candidate = 'X';
                    break;
                case 'y':
                    candidate = 'Y';
                    break;
                case 'z':
                    candidate = 'Z';
                    break;
            }
            return candidate;
        }
    }
}
