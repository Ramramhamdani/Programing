using System;
using System.Collections.Generic;

namespace Assignment_3
{

    class DeckOfCards
    {
        public List<PlayingCard> cards = new List<PlayingCard>();
        public DeckOfCards()
        {
            InitCards(cards);
        }
        void InitCards(List<PlayingCard> cards)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int rank = 1; rank <= 13; rank++)
                {
                    PlayingCard card = new PlayingCard((Rank)rank, (CardSuit)i);
                    cards.Add(card);
                }
                //for (int rank = 1; rank <= 4; rank++)
                //{
                //    PlayingCard card = new PlayingCard(((Rank)rank).ToString(), (CardSuit)i);
                //    cards.Add(card);
                //}
            }
        }
        public void Print()
        {
            string print;
            foreach (PlayingCard card in cards)
            {
                print = card.ToString();
                Console.WriteLine(print);
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            PlayingCard shuffle = new PlayingCard();
            int pos1, pos2;
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


}
