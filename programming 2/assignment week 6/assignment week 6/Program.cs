using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            ChessPiece[,] chessboard = new ChessPiece[8, 8];
            InitChessboard(chessboard);
            DisplayChessboard(chessboard);
            Console.ReadKey();
        }
        void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = null;
                }
            }
        }
        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            string letters = "ABCDEFGH";
            Console.Write("  ");
            foreach (char item in letters)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine();
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write((row+1)+" ");
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    
                    if ((row+col)%2==0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else 
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    //else if (col==0)
                    //{
                    //    Console.Write(row);
                    //}
                    Console.Write("   ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
