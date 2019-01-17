using System;

namespace Assignment_2
{

    class Program
    {
        public const int row = 6;
        public const int col = 10;
        public const int min = 1;
        public const int max = 100;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int[,] matrix = new int[row, col];
            FillMatrix(matrix);
            SortMatrix(matrix);
            DisplayMatrix(matrix);
            Console.ReadKey();
        }
        void FillMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[rows, column] = random.Next(min, max);
                }
            }
        }
        void DisplayMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    Console.ResetColor();
                    if (matrix[rows, columns] > 1 && matrix[rows, columns] < 19)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (matrix[rows, columns] > 20 && matrix[rows, columns] < 39)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (matrix[rows, columns] > 40 && matrix[rows, columns] < 59)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (matrix[rows, columns] > 60 && matrix[rows, columns] < 79)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (matrix[rows, columns] > 80 && matrix[rows, columns] < 99)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write("{0:00} ",matrix[rows, columns]);
                }
                Console.WriteLine();
            }
        }
        void SortRow(int[,] matrix, int row2)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int lowestIndex = matrix[row2, column];
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (lowestIndex > matrix[row2, cols])
                    {
                        lowestIndex = matrix[row2, cols];
                    }
                    if (lowestIndex != matrix[row2, column])
                    {
                        matrix[row2, cols] = matrix[row2, column];
                        matrix[row2, column] = lowestIndex;
                    }
                }

            }

        }
        void SortMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                SortRow(matrix, rows);
            }
            for (int Columns = 0; Columns < matrix.GetLength(1); Columns++)
            {
                SortColumn(matrix, Columns);
            }
        }
        void SortColumn(int[,] matrix,int column)
        {
            for (int row2 = 0; row2 < matrix.GetLength(0); row2++)
            {
                int lowestIndex = matrix[row2, column];
                for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
                {
                    if (lowestIndex > matrix[row1, column])
                    {
                        lowestIndex = matrix[row1, column];
                    }
                    if (lowestIndex != matrix[row2, column])
                    {
                        matrix[row1, column] = matrix[row2, column];
                        matrix[row2, column] = lowestIndex;
                    }
                }

            }
        }
    }
}
