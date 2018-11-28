using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        void start()
        {
            int[,] chessboard = new int[8, 8];
            position position = new position();
            InitChessboard(chessboard);
            position = PositionKnight(chessboard);
            PossibleKnightMoves(chessboard, position);
            DisplayChessboard(chessboard);
            Console.ReadKey();
        }
        void InitChessboard(int[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = 0;
                }
            }
        }
        void DisplayChessboard(int[,] chessboard)
        {
            string space = "";
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if (chessboard[row,col]==0)
                    {
                        space = ". ";
                    }
                    else if (chessboard[row,col]==1)
                    {
                        space = "* ";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (chessboard[row,col]==2)
                    {
                        space = "* ";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(space);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        position PositionKnight(int[,] chessboard)
        {
            Random rndrow = new Random();
            Random rndcol = new Random();
            position position = new position();
            position.row = rndrow.Next(0, chessboard.GetLength(0));
            position.column = rndcol.Next(0, chessboard.GetLength(1));
            chessboard[position.row, position.column] = 1;
            return position;
        }
        void PossibleKnightMoves(int[,] chessboard, position position)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if ((position.row < chessboard.GetLength(0)- 2)&&(position.column>1))
                    {
                        chessboard[position.row + 2, position.column-1] = 2;
                    }
                    if ((position.row< chessboard.GetLength(0)-2)&&(position.column<chessboard.GetLength(1)-1))
                    {
                        chessboard[position.row + 2, position.column + 1] = 2;
                    }
                    if ((position.row < chessboard.GetLength(0) - 1) && (position.column < chessboard.GetLength(1) - 2))
                    {
                        chessboard[position.row + 1, position.column + 2] = 2;
                    }
                    if ((position.row < chessboard.GetLength(0) - 1) && (position.column > 2))
                    {
                        chessboard[position.row + 1, position.column - 2] = 2;
                    }
                    if ((position.row > 2) && (position.column < chessboard.GetLength(1)-1))
                    {
                        chessboard[position.row - 2, position.column + 1] = 2;
                    }
                    if ((position.row!=0)&&(position.row < chessboard.GetLength(0) - 1) && (position.column < chessboard.GetLength(1) - 2))
                    {
                        chessboard[position.row - 1, position.column + 2] = 2;
                    }
                    if ((position.row > 2) && (position.column > 1))
                    {
                        chessboard[position.row - 2, position.column - 1] = 2;
                    }
                    if ((position.row > 1) && (position.column > 2))
                    {
                        chessboard[position.row - 1, position.column - 2] = 2;
                    }
                }
            }
        }
    }
}
