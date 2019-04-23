using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapon : GameOject
    {
        public Type type;
        public enum Type { Sword,Axe,Crossbow,Dagger}

    }
    class Inventory
    {
        List<GameOject> gameOjects = new List<GameOject>();
    }

    class Player
    {
        Inventory Inventory = new Inventory();
    }
}
