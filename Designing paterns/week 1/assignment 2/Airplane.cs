using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Airplane : IFlyable
    {
        public void Fly(int n)
        {
            while (n > 0)
            {
                Console.WriteLine("airplane is flying around...");
                n--;
            }
        }

        public void Land()
        {
            Console.WriteLine("airplane is landing..."+"\n");
        }

        public void LiftOff()
        {
            Console.WriteLine("airpalne is lifting off..");
        }
    }
}
