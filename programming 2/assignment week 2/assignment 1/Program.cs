using System;

namespace assignment_1
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
            int[,] matrix = new int[11, 11];
            InitMatrixLinear(matrix);
            DisplayMatrixWithCross(matrix);
            Console.ReadKey();
        }
        void InitMatrix2D(int[,] matrix)
        {
            int n = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = n;
                    n++;
                }
            }
        }
        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].ToString().PadLeft(3) + " ");

                }
                Console.WriteLine();
            }
        }
        void InitMatrixLinear(int[,] matrix)
        {
            int n = 120;
            int row = 0;
            int num = 1;
            for (int col = 0; col < n; col++)
            {
                if (col == 11)
                {
                    row++;
                    col = 0;
                }
                if (row == matrix.GetLength(1))
                {
                    break;
                }
                else
                {
                    matrix[row, col] = num;
                    num++;
                }
            }
        }
        void DisplayMatrixWithCross(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (row + col == matrix.GetLength(0) - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                   
                    
                    Console.Write(matrix[row, col].ToString().PadLeft(3) + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
