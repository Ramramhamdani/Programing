using System;
using System.Collections.Generic;
namespace Assignment_3
{
    class Player
    {
        public string name;
        public List<PlayingCard> cards = new List<PlayingCard>();

        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }
        public PlayingCard GetNextCard()
        {
            PlayingCard card = new PlayingCard();
            card = cards[0];
            cards.Remove(cards[0]);
            return card;
        }
        public Player(string name)
        {
            this.name = name;
        }
    }

}
