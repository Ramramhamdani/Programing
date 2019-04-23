using System;

namespace assignment_2
{
    class Superman : IFlyable
    {
        public void Fly(int n)
        {
            while (n > 0)
            {
                Console.WriteLine("Superman is flying around...");
                n--;
            }
        }

        public void Land()
        {
            Console.WriteLine("Superman is landing..."+"\n");
        }

        public void LiftOff()
        {
            Console.WriteLine("Superman is lifting off..");
        }
    }
}
