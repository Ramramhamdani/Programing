using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                dices[i]=die;
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
            bool same=false;
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[0]==dices[1] && dices[0] == dices[2]&& dices[0] == dices[3]&& dices[0] == dices[4])
                {
                    same = true;
                }
                else
                {
                    same = false;
                }
            }
            return same;
        }
    }
}
