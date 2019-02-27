using System.Collections.Generic;
using System;

namespace Assignment_2
{
    class DeckOfCards
    {
        List<PlayingCard> cards = new List<PlayingCard>();
        public DeckOfCards()
        {
            InitCards(cards);
        }
        void InitCards(List<PlayingCard> cards)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j < 11; j++)
                {
                    PlayingCard card = new PlayingCard(j.ToString(), (CardSuit)i);
                    cards.Add(card);
                }
                for (int rank = 1; rank <=4; rank++)
                {
                    PlayingCard card = new PlayingCard(((Rank)rank).ToString(), (CardSuit)i);
                    cards.Add(card);
                }
            }
        }
        public void Print()
        {
            string print;
            foreach (PlayingCard card in cards)
            {
                print= card.ToString();
                Console.WriteLine(print);
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            PlayingCard shuffle = new PlayingCard(Rank.Ace.ToString(),CardSuit.Clubs);
            int pos1,pos2;
            for (int i = 0; i < cards.Count; i++)
            {
                pos1 = random.Next(0, 52);
                shuffle = cards[pos1];
                pos2 = random.Next(0, 52);
                cards[pos1] = cards[pos2];
                cards[pos2] = shuffle;
            }
        }

    }
    class PlayingCard
    {
        public string rank;
        public CardSuit suit;
        public PlayingCard(string rank,CardSuit suit)
        {
            this.suit = suit;
            this.rank = rank;
        }
        
        public override string ToString()
        {
            string card = $"{rank} of {suit}";
            return card;
        }
    }
    enum CardSuit
    {
        Spades = 1, Clubs, Hearts, Diamonds
    }
    enum Rank
    {
        Jack=1,Queen, King, Ace
    }
}
