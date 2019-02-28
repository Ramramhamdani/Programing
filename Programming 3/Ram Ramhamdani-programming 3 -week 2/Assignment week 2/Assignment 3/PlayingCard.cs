namespace Assignment_3
{
    class PlayingCard
    {
        public Rank rank;
        public CardSuit suit;
        public PlayingCard()
        {

        }
        public PlayingCard(Rank rank, CardSuit suit)
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


}
