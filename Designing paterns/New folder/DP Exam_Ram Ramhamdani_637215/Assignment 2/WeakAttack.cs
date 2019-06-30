using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class WeakAttack : IAttackBehaviour 
    {
        public void Attack()
        {
            Console.WriteLine("Weak attack...");
        }
    }
}
