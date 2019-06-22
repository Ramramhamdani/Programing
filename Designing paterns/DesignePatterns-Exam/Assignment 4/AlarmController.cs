using System;

namespace Assignment_4
{
    class AlarmController : IAlarmController
    {
        AlarmSystem AlarmSystem;

        public AlarmController()
        {
            AlarmSystem = new AlarmSystem();
        }


        public void ActivateAlarm(string msg)
        {
            DateTime dateTime = DateTime.Today;
            AlarmSystem.ActivateAlarm(dateTime, msg);
            AlarmSystem.NotifyObserver();
        }
    }
}
