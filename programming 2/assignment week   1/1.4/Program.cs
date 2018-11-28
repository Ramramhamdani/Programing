using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Satrt();
        }
        void Satrt()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            yahtzeeGame.Init();
            PlayYahtzee(yahtzeeGame);
            Console.WriteLine();
           
            Console.ReadKey();
        }
        void PlayYahtzee(YahtzeeGame game)
        {
            int three=0;
            int four = 0;
            int nrOfAttempts = 0;
            do
            {
                game.Throw();
                game.DisplayValues();
                nrOfAttempts++;
                Console.WriteLine();
                if (game.ThreeOfAKind())
                {
                    three++;
                }
                else if (game.FourOfAKind())
                {
                    four++;
                }
                
            } while ((!game.Yahtzee()) );
           
            Console.WriteLine("Number of attempts needed (Yahtzee): {0}", nrOfAttempts);
            Console.WriteLine("three of a kind {0}", three);
            Console.WriteLine("four of a kind {0}", four);
        }
    }
}
