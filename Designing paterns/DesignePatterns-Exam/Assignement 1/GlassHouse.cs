using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_1
{
    class GlassHouse:BaseHouse
    {
        public override void Walls()
        {
            Console.WriteLine("Building glass walls");
        }
        public override void Roof()
        {
            Console.WriteLine("building glass roof");
        }
    }
}
