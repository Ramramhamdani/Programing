using System;
using System.IO;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                program.start();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured! {0}", e);
                Console.ReadKey();
            }
        }
        void start()
        {
            RegularCandies[,] playingfield = new RegularCandies[9, 9];
            if (File.Exists("Play"))
            {
                playingfield = ReadPlayingField("Play");
            }
            else
            {
                InitCandies(playingfield);
                WritePlayingField(playingfield, "Play");
            }

            DisplayCandies(playingfield);
            ScoreRowPresent(playingfield);
            Console.ResetColor();
            if (ScoreRowPresent(playingfield))
            {
                Console.WriteLine("row score!");
            }
            else
            {
                Console.WriteLine("no row score!");
            }
            ScoreColumnPresent(playingfield);
            if (ScoreColumnPresent(playingfield))
            {
                Console.WriteLine("column score!");
            }
            else
            {
                Console.WriteLine("no column score!");
            }
            Console.ReadKey();

        }
        void InitCandies(RegularCandies[,] candies)
        {
            Random rnd = new Random();
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    RegularCandies candy = (RegularCandies)rnd.Next(1, 7);
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
                    switch (candies[row, col])
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
            int count = 1;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 2; col < candies.GetLength(1); col++)
                {
                    //...  
                    if ((candies[row, col] == candies[row, col - 2]) && (candies[row, col] == candies[row, col - 1]))
                    {
                        return true;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool ScoreColumnPresent(RegularCandies[,] candies)
        {
            int count = 1;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    if ((row == 0) || (row == 1))
                    {
                        continue;
                    }
                    else if ((candies[row, col] == candies[row - 2, col]) && (candies[row, col] == candies[row - 1, col]))
                    {
                        count++;
                    }

                    if (count >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        void WritePlayingField(RegularCandies[,] playField, string filename)
        {
            int input = 0;
            StreamWriter writer = new StreamWriter(filename);
            for (int row = 0; row < playField.GetLength(0); row++)
            {
                for (int col = 0; col < playField.GetLength(1); col++)
                {
                    switch (playField[row, col])
                    {
                        case RegularCandies.JellyBean:
                            input = 1;
                            break;
                        case RegularCandies.LozengeOrange:
                            input = 2;
                            break;
                        case RegularCandies.LemonDropYellow:
                            input = 3;
                            break;
                        case RegularCandies.GumSquareGreen:
                            input = 4;
                            break;
                        case RegularCandies.LollipopHeadBlue:
                            input = 5;
                            break;
                        case RegularCandies.JujubeClusterPurple:
                            input = 6;
                            break;
                        default:
                            break;
                    }
                    writer.Write(input);
                   
                    if (col != 8)
                    {
                        writer.Write(" ");
                    }
                }
                writer.Write(" ");
                writer.WriteLine();
            }
            writer.Close();
        }
        RegularCandies[,] ReadPlayingField(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            RegularCandies[,] playing = new RegularCandies[9, 9];
            int[] num = new int[81];
            string line = "";
            while (!reader.EndOfStream)
            {
                line = line + reader.ReadLine();
            }
            string[] numberStrings = line.Split(' ');
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (numberStrings[i] != " ")
                {
                    num[i] = int.Parse(numberStrings[i]);
                    //how to fill the array from a file?
                }
            }
            for (int row = 0; row < playing.GetLength(0); row++)
            {
                for (int col = 0; col < playing.GetLength(1); col++)
                {


                    RegularCandies candy = (RegularCandies)num[col];
                    playing[row, col] = candy;

                }
            }
            reader.Close();
            return playing;

        }
    }
}
