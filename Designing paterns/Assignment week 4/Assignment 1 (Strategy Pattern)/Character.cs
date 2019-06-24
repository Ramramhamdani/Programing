using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1__Strategy_Pattern_
{
    class Character
    {
        private IWeaponBehaviour weapon;
        public IWeaponBehaviour Weapon { get { return weapon; } set { weapon = value; } }

        public Character()
        {

        }
        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
