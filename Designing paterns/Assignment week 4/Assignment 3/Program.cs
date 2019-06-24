using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.AssignDriver("Frank");

            Adapter Robot = new Adapter();
            Robot.AssignDriver("Mark");

            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(Robot);

            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
            }

            Console.ReadKey();
        }
    }
}
