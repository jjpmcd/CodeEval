using System;
using System.IO;
using System.Text;

namespace QueryBoard.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var fileStream = File.OpenRead(args[0]))
            {
                using (var reader = new StreamReader(fileStream, Encoding.ASCII, false))
                {
                    var queryBoard = new byte[256][];
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        var result = Board.Query(line, queryBoard);
                        if (result != -1) { Console.WriteLine(result); }
                    }
                }
            }
        }
    }

    public static class Board
    {
        public static int Query(string input, byte[][] queryBoard)
        {
            var splitInput = input.Split(' ');
            var target = IntParseFast(splitInput[1]);
            int sum = -1;

            if (input[3] == 'R')
            {
                SetRow(queryBoard, target, (byte) IntParseFast(splitInput[2]));
            }
            else if (input[3] == 'C')
            {
                SetCol(queryBoard, target, (byte) IntParseFast(splitInput[2]));
            }
            else if (input[5] == 'R')
            {
                sum = QueryRow(queryBoard, target);
            }
            else if (input[5] == 'C')
            {
                sum = QueryCol(queryBoard, target);
            }

            return sum;
        }

        private static int QueryCol(byte[][] queryBoard, int target)
        {
            int sum = 0;
            for (var i = 0; i < 256; i++)
            {
                if (queryBoard[i] != null)
                {
                    sum += queryBoard[i][target];
                }
            }

            return sum;
        }

        private static int QueryRow(byte[][] queryBoard, int target)
        {
            int sum = 0;
            for (var i = 0; i < 256; i++)
            {
                if (queryBoard[target] != null)
                {
                    sum += queryBoard[target][i];
                }
            }

            return sum;
        }

        private static void SetCol(byte[][] queryBoard, int target, byte value)
        {
            for (var i = 0; i < 256; i++)
            {
                if (queryBoard[i] == null)
                {
                    queryBoard[i] = new byte[256];
                }
                queryBoard[i][target] = value;
            }
        }

        private static void SetRow(byte[][] queryBoard, int target, byte value)
        {
            for (var i = 0; i < 256; i++)
            {
                if (queryBoard[target] == null)
                {
                    queryBoard[target] = new byte[256];
                }
                queryBoard[target][i] = value;
            }
        }

        private static int IntParseFast(string value)
        {
            var result = 0;

            for (var i = 0; i < value.Length; i++)
            {
                result = 10 * result + (value[i] - 48);
            }

            return result;
        }
    }
}
