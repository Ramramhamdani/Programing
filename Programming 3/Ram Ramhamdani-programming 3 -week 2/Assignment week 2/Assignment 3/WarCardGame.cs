using System;
namespace Assignment_3
{
    class WarCardGame:CardGame
    {
        public Player player1;
        public Player player2;
        public WarCardGame(Player player1,Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public void StartNewGame()
        {
            deck.Shuffle();
            for (int i = 0; i < deck.cards.Count-1; i++)
            {
                player1.cards.Add(deck.cards[i]);
                i++;
                player2.cards.Add(deck.cards[i]);
            }
        }
        public bool EndOfGame()
        {
            if (player1.cards.Count==0||player2.cards.Count==0)
            {
                return true;
            }
            return false;
        }
        public void NextCard()
        {
            int i = 1;
            while (/*int i = 0; i < deck.cards.Count; i++*/!EndOfGame())
            {
                PlayingCard pl1 = player1.GetNextCard();
                PlayingCard pl2 = player2.GetNextCard();
                Console.WriteLine($"[{player1.name}] {pl1.rank.ToString()} of {pl1.suit} -" +
                    $" [{player2.name}] {pl2.rank.ToString()} of {pl2.suit}");
                if ((int)pl1.rank>(int)pl2.rank)
                {
                    player1.cards.Add(pl2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{player1.name} got the cards");
                }
                else if ((int)pl2.rank > (int)pl1.rank)
                {
                    player2.cards.Add(pl1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{player2.name} got the cards");
                }
                else if((int)pl1.rank==(int)pl2.rank)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2 cards lost"+"\n"+$"[{player1.name}] {player1.cards.Count}X,[{player2.name}] {player2.cards.Count}X");
                }
                Console.ResetColor();
                i++;
            }
        }
    }
}
