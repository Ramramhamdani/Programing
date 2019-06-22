using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class AlarmDisplay : IAlarmObserver
    {
        AlarmSystem AlarmSystem;

        public AlarmDisplay()
        {
            AlarmSystem = new AlarmSystem();
        }
        

        public void Update(DateTime dateTime, string msg)
        {
            AlarmSystem.alarmDateTime = dateTime;
            AlarmSystem.alarmMessage = msg;
            Console.WriteLine($"[alarm-display]: alarm activated at {AlarmSystem.alarmDateTime.ToString()}");
        }
    }
}
