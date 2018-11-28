using System;

namespace assignment_2
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
            int max = 100;
            int min = 1;
            int[,] matrix = new int[11, 11];
            InitMatrixRandom(matrix, min, max);
            DisplayMatrix(matrix);
            Console.Write("Enter a number (to search for): ");
            int number = int.Parse(Console.ReadLine());
            position position = SearchNumber(matrix, number);
            Console.WriteLine("Number {0} is found (first) at position [row,col] = [{1},{2}]", number, position.row, position.column);
            position backPosition = SearchNumberBackwards(matrix, number);
            Console.WriteLine("Number {0} is found (last) at position [row,col] = [{1},{2}]", number, backPosition.row, backPosition.column);

            Console.ReadKey();
        }
        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(min, max);
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
        position SearchNumber(int[,] matrix, int number)
        {
            position position = new position();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == number)
                    {
                        position.row = row + 1;
                        position.column = col + 1;
                        return position;
                    }
                }
            }
            return position;
        }
        position SearchNumberBackwards(int[,] matrix, int number)
        {
            position position = new position();
            for (int row = matrix.GetLength(0) - 1; row > 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col > 0; col--)
                {
                    if (matrix[row, col] == number)
                    {
                        position.row = row + 1;
                        position.column = col + 1;
                        return position;
                    }
                }
            }
            return position;
        }
    }
}
