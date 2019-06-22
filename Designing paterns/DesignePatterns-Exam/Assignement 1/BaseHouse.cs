using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_1
{
    class BaseHouse
    {
        public void BuildHouse()
        {
            Foundation();
            Walls();
            Roof();
            Windows();
        }
        public void Foundation()
        {
            Console.WriteLine("Building foundation");
        }
        public virtual void Walls()
        {
            Console.WriteLine("Walls");
        }
        public virtual void Roof()
        {
            Console.WriteLine("Roof");
        }
        public void Windows()
        {
            Console.WriteLine("Placing windows");
        }
    }
}
