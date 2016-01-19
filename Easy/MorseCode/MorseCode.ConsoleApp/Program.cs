using System;
using System.IO;
using System.Text;

namespace MorseCode.ConsoleApp
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
                        Console.WriteLine(Morser.GetDecodedMessage(line));
                    }
                }
            }
        }
    }

    public static class Morser
    {
        public static string GetDecodedMessage(string input)
        {
            var output = "";
            var startIndex = 0;
            var length = 0;

            for (var index = 0; index < input.Length; index++)
            {
                if (input[index] != ' ')
                {
                    length++;
                    continue;
                }
                output += GetDecodeCharacter(input.Substring(startIndex, length));

                if (input[index + 1] == ' ')
                {
                    index++;
                    output += ' ';
                }

                startIndex = index + 1;
                length = 0;
            }

            output += GetDecodeCharacter(input.Substring(startIndex));

            return output;
        }

        private static char GetDecodeCharacter(string input)
        {
            if (input.Length != 5)
            {
                switch (input)
                {
                    case ".-":
                        return 'A';
                    case "-...":
                        return 'B';
                    case "-.-.":
                        return 'C';
                    case "-..":
                        return 'D';
                    case ".":
                        return 'E';
                    case "..-.":
                        return 'F';
                    case "--.":
                        return 'G';
                    case "....":
                        return 'H';
                    case "..":
                        return 'I';
                    case ".---":
                        return 'J';
                    case "-.-":
                        return 'K';
                    case ".-..":
                        return 'L';
                    case "--":
                        return 'M';
                    case "-.":
                        return 'N';
                    case "---":
                        return 'O';
                    case ".--.":
                        return 'P';
                    case "--.-":
                        return 'Q';
                    case ".-.":
                        return 'R';
                    case "...":
                        return 'S';
                    case "-":
                        return 'T';
                    case "..-":
                        return 'U';
                    case "...-":
                        return 'V';
                    case ".--":
                        return 'W';
                    case "-..-":
                        return 'X';
                    case "-.--":
                        return 'Y';
                    case "--..":
                        return 'Z';
                }
            }
            else
            {
                switch (input)
                {
                    case ".----":
                        return '1';
                    case "..---":
                        return '2';
                    case "...--":
                        return '3';
                    case "....-":
                        return '4';
                    case ".....":
                        return '5';
                    case "-....":
                        return '6';
                    case "--...":
                        return '7';
                    case "---..":
                        return '8';
                    case "----.":
                        return '9';
                    case "-----":
                        return '0';
                }
            }
            throw new ArgumentException("Unexpected Morse Code.");
        }
    }
}
