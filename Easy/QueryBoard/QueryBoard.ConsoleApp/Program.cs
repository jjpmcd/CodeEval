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
                    var queryBoard = Board.GetNewBoard();
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
        public static int Query(string input, int[][] queryBoard)
        {
            var splitInput = input.Split(' ');
            var target = IntParseFast(splitInput[1]);
            int sum = -1;

            if (input[3] == 'R')
            {
                SetRow(queryBoard, target, IntParseFast(splitInput[2]));
            }
            else if (input[3] == 'C')
            {
                SetCol(queryBoard, target, IntParseFast(splitInput[2]));
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

        private static int QueryCol(int[][] queryBoard, int target)
        {
            int sum = 0;
            for (var i = 0; i < queryBoard.Length; i++)
            {
                sum += queryBoard[i][target];
            }

            return sum;
        }

        private static int QueryRow(int[][] queryBoard, int target)
        {
            int sum = 0;
            for (var i = 0; i < queryBoard[target].Length; i++)
            {
                sum += queryBoard[target][i];
            }

            return sum;
        }

        private static void SetCol(int[][] queryBoard, int target, int value)
        {
            for (var i = 0; i < queryBoard.Length; i++)
            {
                queryBoard[i][target] = value;
            }
        }

        private static void SetRow(int[][] queryBoard, int target, int value)
        {
            for (var i = 0; i < queryBoard[target].Length; i++)
            {
                queryBoard[target][i] = value;
            }
        }

        public static int[][] GetNewBoard()
        {
            var queryBoard = new int[256][];
            for (var i = 0; i < queryBoard.Length; i++)
            {
                queryBoard[i] = new int[256];
            }
            return queryBoard;
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
