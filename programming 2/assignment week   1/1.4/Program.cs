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

            yahtzeeGame.Throw();
            yahtzeeGame.DisplayValues();
            Console.WriteLine();

            yahtzeeGame.Throw();
            yahtzeeGame.DisplayValues();
            Console.ReadKey();
        }
    }
}
