using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        void Start()
        {
            // create alarmsystem
            IAlarmSystem alarmSystem = new AlarmSystem();

            // create controller
            //... (TODO)
            AlarmController controller = new AlarmController();

            // create displays
            //... (TODO)
            AlarmExtendedDisplay alarmExtendedDisplay = new AlarmExtendedDisplay();
            AlarmDisplay alarmDisplay = new AlarmDisplay();
            alarmSystem.AddObserver(alarmDisplay);
            alarmSystem.AddObserver(alarmExtendedDisplay);

            // activate the alarm system a few times (for testing)
            controller.ActivateAlarm("backdoor is open");
            Console.WriteLine();
            controller.ActivateAlarm("smoke in room H1-10");
            Console.WriteLine();
        }
    }
}
