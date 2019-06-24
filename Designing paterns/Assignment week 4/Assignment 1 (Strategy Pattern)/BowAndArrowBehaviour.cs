﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1__Strategy_Pattern_
{
    class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with a bow");
        }
    }
}
