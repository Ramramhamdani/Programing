using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
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
            RegularCandies[,] playingfield = new RegularCandies[9, 9];
            InitCandies(playingfield);
            DisplayCandies(playingfield);
            ScoreRowPresent(playingfield);
            Console.ResetColor();
            if (ScoreRowPresent(playingfield))
            {
                Console.WriteLine("row score!");
            }
            ScoreColumnPresent(playingfield);
            if (ScoreColumnPresent(playingfield))
            {
                Console.WriteLine("column score!");
            }
            Console.ReadKey();
            
        }
        void InitCandies(RegularCandies[,] candies)
        {
            Random rnd = new Random();
            string n;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    RegularCandies candy =(RegularCandies) rnd.Next(1, 7);
                    candies[row, col] = candy;
                }
            }
        }
        void DisplayCandies(RegularCandies[,] candies)
        {
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    switch (candies[row,col])
                    {
                        case RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case RegularCandies.LozengeOrange:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case RegularCandies.LemonDropYellow:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.GumSquareGreen:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.LollipopHeadBlue:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case RegularCandies.JujubeClusterPurple:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default:
                            Console.ResetColor();
                            break;
                    }
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        bool ScoreRowPresent(RegularCandies[,] candies)
        {
            int count = 0;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    if ((col==candies.GetLength(1))||(col==0)||(col==1))
                    {
                        continue;
                    }
                    else if ((candies[row, col] == candies[row, col - 2]) && (candies[row, col] == candies[row, col - 1]))
                    {
                        count++;
                    }

                    if (count>=3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool ScoreColumnPresent(RegularCandies[,] candies)
        {
            int count = 0;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    if ((row == candies.GetLength(1)) || (row == 0) || (row == 1))
                    {
                        continue;
                    }
                    else if ((candies[row, col] == candies[row-2, col]) && (candies[row, col] == candies[row-1, col]))
                    {
                        count++;
                    }

                    if (count >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
