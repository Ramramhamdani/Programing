using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start(args);
        }
        void Start(string[] args)
        {
            IFlyable s = new Superman();
            IFlyable a = new Airplane();

            MakeFlight(s);
            MakeFlight(a);
            Console.ReadKey();
        }
        void MakeFlight(IFlyable flyable)
        {
            flyable.LiftOff();
            flyable.Fly(3);
            flyable.Land();
        }
    }
}
