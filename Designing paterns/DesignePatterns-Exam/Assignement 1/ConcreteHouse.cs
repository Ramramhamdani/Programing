using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_1
{
    class ConcreteHouse:BaseHouse
    {
        public override void Walls()
        {
            Console.WriteLine("Building concrete walls");
        }
        public override void Roof()
        {
            Console.WriteLine("building concrete roof");
        }
    }
}
