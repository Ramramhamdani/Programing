using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Adapter : IAttacker
    {
        Robot robot = new Robot();

        public void AssignDriver(string Driver)
        {
            robot.MovedByPerson(Driver);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
