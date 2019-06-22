using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_1
{
    class WoodenHouse : BaseHouse
    {
        public override void Walls()
        {
            Console.WriteLine("Building wooden walls");
        }
        public override void Roof()
        {
            Console.WriteLine("building wooden roof");
        }
    }
}
