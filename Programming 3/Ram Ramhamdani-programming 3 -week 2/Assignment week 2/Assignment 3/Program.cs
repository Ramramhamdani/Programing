using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Assignment_3
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
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
            Console.ReadKey();
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }
            if (war.player1.cards.Count==0)
            {
                Console.WriteLine($"{war.player2.name} has won!");
            }
            else
            {
                Console.WriteLine($"{war.player1.name} has won!");
            }
        }
    }
}
