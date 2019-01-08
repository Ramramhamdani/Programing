using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CandyCrushLogic;

namespace CandyCrush_application
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
            CandyCrusher.RegularCandies[,] playingfield = new CandyCrusher.RegularCandies[9, 9];
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
            CandyCrusher.ScoreRowPresent(playingfield);
            Console.ResetColor();
            if (CandyCrusher.ScoreRowPresent(playingfield))
            {
                Console.WriteLine("row score!");
            }
            else
            {
                Console.WriteLine("no row score!");
            }
            CandyCrusher.ScoreColumnPresent(playingfield);
            if (CandyCrusher.ScoreColumnPresent(playingfield))
            {
                Console.WriteLine("column score!");
            }
            else
            {
                Console.WriteLine("no column score!");
            }
            Console.ReadKey();

        }
        void InitCandies(CandyCrusher.RegularCandies[,] candies)
        {
            Random rnd = new Random();
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    CandyCrusher.RegularCandies candy = (CandyCrusher.RegularCandies)rnd.Next(1, 7);
                    candies[row, col] = candy;
                }
            }
        }
        void DisplayCandies(CandyCrusher.RegularCandies[,] candies)
        {
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    switch (candies[row, col])
                    {
                        case CandyCrusher.RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case CandyCrusher.RegularCandies.LozengeOrange:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case CandyCrusher.RegularCandies.LemonDropYellow:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case CandyCrusher.RegularCandies.GumSquareGreen:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case CandyCrusher.RegularCandies.LollipopHeadBlue:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case CandyCrusher.RegularCandies.JujubeClusterPurple:
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
        
        void WritePlayingField(CandyCrusher.RegularCandies[,] playField, string filename)
        {
            int input = 0;
            StreamWriter writer = new StreamWriter(filename);
            for (int row = 0; row < playField.GetLength(0); row++)
            {
                for (int col = 0; col < playField.GetLength(1); col++)
                {
                    switch (playField[row, col])
                    {
                        case CandyCrusher.RegularCandies.JellyBean:
                            input = 1;
                            break;
                        case CandyCrusher.RegularCandies.LozengeOrange:
                            input = 2;
                            break;
                        case CandyCrusher.RegularCandies.LemonDropYellow:
                            input = 3;
                            break;
                        case CandyCrusher.RegularCandies.GumSquareGreen:
                            input = 4;
                            break;
                        case CandyCrusher.RegularCandies.LollipopHeadBlue:
                            input = 5;
                            break;
                        case CandyCrusher.RegularCandies.JujubeClusterPurple:
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
        CandyCrusher.RegularCandies[,] ReadPlayingField(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            CandyCrusher.RegularCandies[,] playing = new CandyCrusher.RegularCandies[9, 9];
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
                    CandyCrusher.RegularCandies candy = (CandyCrusher.RegularCandies)num[col];
                    playing[row, col] = candy;
                }
            }
            reader.Close();
            return playing;

        }
    }
}
