using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Tank : IAttacker
    {
        private string generator;

        public void AssignDriver(string driver)
        {
            generator = driver;
            Console.WriteLine($"{generator} is steering the tank");
        }

        public void DriveForward()
        {
            Console.WriteLine($"Tank moves 3 positions forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank Causes damage");
        }
    }
}
