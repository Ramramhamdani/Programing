namespace _1._4
{
    class YahtzeeGame
    {
        Dice[] dices;
        public void Init()
        {
            dices = new Dice[5];
        }
        public void Throw()
        {

            for (int i = 0; i < dices.Length; i++)
            {
                Dice die = new Dice();
                die.Throw();
                dices[i] = die;
            }
        }
        public void DisplayValues()
        {
            foreach (Dice dice in dices)
            {
                dice.DisplayValue();
            }
        }
        public bool Yahtzee()
        {
            int first = dices[0].value;
            
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i].value!=first)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ThreeOfAKind()
        {
            bool three = false; ;
            int[] nr = new int[6];
            foreach (Dice dice in dices)
            {
                nr[dice.value - 1]++;
            }
            foreach (int num in nr)
            {
                if (num>2)
                {
                    three = true;
                }
            }
            
            return three;
        }
        public bool FourOfAKind()
        {
            bool four = false; ;
            int[] nr = new int[6];
            foreach (Dice dice in dices)
            {
                nr[dice.value - 1]++;
            }
            foreach (int num in nr)
            {
                if (num> 3)
                {
                    four = true;
                }
            }

            return four;
        }

    }
}
