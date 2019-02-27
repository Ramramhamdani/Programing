using System;

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
            PlayChess(chessboard);
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
            PutChessPieces(chessboard);
        }
        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            string letters = "ABCDEFGH";
            Console.Write("  ");
            foreach (char item in letters)
            {
                Console.Write("   " + item + "  ");
            }
            Console.WriteLine();
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write((row + 1) + " ");
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {

                    if ((row + col) % 2 == 0)
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
                    DisplayChessPiece(chessboard[row, col]);
                    Console.Write("   ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.king,
                ChessPieceType.queen, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    ChessPiece piece = new ChessPiece();
                    piece.type = order[col];
                    
                    if (row==0)
                    {
                        piece.color = ChessPieceColor.black;
                        chessboard[row, col] = piece;
                    }
                    else if (row==7)
                    {
                        piece.color = ChessPieceColor.white;
                        chessboard[row, col] = piece;
                    }
                    else if (row==1|| row==6)
                    {
                        piece.type = ChessPieceType.Pawn;
                        if (row==1)
                        {
                            piece.color = ChessPieceColor.black;
                        }
                        else
                        {
                            piece.color = ChessPieceColor.white;
                        }
                        chessboard[row, col] = piece;
                    }
                }
            }
        }
        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece!=null)
            {
                if (chessPiece.color==ChessPieceColor.black)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (chessPiece.color==ChessPieceColor.white)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                switch (chessPiece.type)
                {
                    case ChessPieceType.Pawn:
                        Console.Write(" p ");
                        break;
                    case ChessPieceType.Rook:
                        Console.Write(" r ");
                        break;
                    case ChessPieceType.Knight:
                        Console.Write(" k ");
                        break;
                    case ChessPieceType.king:
                        Console.Write(" K ");
                        break;
                    case ChessPieceType.queen:
                        Console.Write(" Q ");
                        break;
                    case ChessPieceType.Bishop:
                        Console.Write(" b ");
                        break;
                }
            }
            else
            {
                Console.Write("   ");
            }
        }
        Position ReadPosition(string question)
        {
            try
            {
                Console.WriteLine(question);
                string userPos = Console.ReadLine();
                int column = userPos[0] - 'A';
                int row = int.Parse(userPos[1].ToString()) - 1;
                Position position = new Position();
                position.fieldRow = row;
                position.fieldCol = column;
                return position;
            }
            catch (Exception e)
            {

                throw e;

            }
            
        }
        void PlayChess(ChessPiece[,] chessboard)
        {
            while (true)
            {
                Position from = ReadPosition("Enter from-position (eg.A2):");
                Position to = ReadPosition("Enter to-position (eg.A2):");
                CheckMove(chessboard,from,to);
                //DoMove(chesboard,from,to);
                DisplayChessboard(chessboard);
            }
        }
        void DoMove(ChessPiece[,] chessboard, Position from,Position to)
        {
            chessboard[to.fieldRow, to.fieldCol] = chessboard[from.fieldRow, from.fieldCol];
            chessboard[from.fieldRow, from.fieldCol] = null;
        }
        void CheckMove(ChessPiece[,] chessboard ,Position from,Position to)
        {
            if (chessboard[from.fieldRow,from.fieldCol]==null)
            {
                Console.WriteLine("No chess piece at from-position");
            }
            else if (chessboard[to.fieldRow,to.fieldCol]!=null)
            {
                Console.WriteLine("the position is already occupied");
            }
            else if (!ValidMove(chessboard[from.fieldRow, from.fieldCol], from, to))
            {
                Console.WriteLine("Invalid move!");
            }
            else
            {
                DoMove(chessboard, from, to);
            }
        }
        bool ValidMove(ChessPiece chessPiece, Position from, Position to)
        {
            int ver = Math.Abs(to.fieldRow - from.fieldRow);
            int hor = Math.Abs(to.fieldCol - from.fieldCol);
            if (ver==0 && hor==0)
            {
                Console.Write("invalid move!");
                return false;
            }
            switch (chessPiece.type)
            {
                case ChessPieceType.Pawn:
                    if (hor==0&&ver==1)
                    {
                        return true;
                    }
                    break;
                case ChessPieceType.Rook:
                    if (hor*ver ==0)
                    {
                        return true;
                    }
                    break;
                case ChessPieceType.Knight:
                    if (hor*ver == 2)
                    {
                        return true;
                    }
                    break;
                case ChessPieceType.king:
                    if (hor == 1 || ver == 1)
                    {
                        return true;
                    }
                    break;
                case ChessPieceType.queen:
                    if (hor*ver == 0 || hor == ver)
                    {
                        return true;
                    }
                    break;
                case ChessPieceType.Bishop:
                    if (hor == ver)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
