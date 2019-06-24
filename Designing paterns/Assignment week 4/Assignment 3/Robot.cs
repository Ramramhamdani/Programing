using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Robot
    {
        string generator;

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }
        public void MovedByPerson(string person)
        {
            generator = person;
            Console.WriteLine($"Robot is moved by {generator} ");
        }
        public void WalkForward()
        {
            Console.WriteLine("Robot walks 3 steps forward");
        }
    }
}
