using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
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
            DeckOfCards deck = new DeckOfCards();
            deck.Print();
            deck.Shuffle();
            deck.Print();
            Console.ReadKey();
        }
    }
}
