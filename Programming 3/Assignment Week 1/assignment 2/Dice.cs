using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Dice
    {
        public int value;
        // Static random generator removed
        Random rnd = new Random();
        public Dice(Random random)
        {
            this.rnd = random;
        }
        public void Throw()
        {
            value = rnd.Next(1,7);
        }
        public void DisplayValue()
        {
            Console.Write(" " + value);
        }
    }
    
}
