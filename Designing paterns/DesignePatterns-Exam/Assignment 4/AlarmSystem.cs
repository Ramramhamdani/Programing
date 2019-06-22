using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class AlarmSystem : IAlarmSystem
    {
        public DateTime alarmDateTime;
        public string alarmMessage;



        List<IAlarmObserver> observers;

        public AlarmSystem()
        {
            observers = new List<IAlarmObserver>();
        }

        public void ActivateAlarm(DateTime dateTime , string msg)
        {
            alarmDateTime = dateTime;
            alarmMessage = msg;
            Console.WriteLine($"{alarmMessage}  {alarmDateTime.ToString()}");
        }

        public void AddObserver(IAlarmObserver alarmObserver)
        {
            observers.Add(alarmObserver);
        }

        public void RemoveObserver(IAlarmObserver alarmObserver)
        {
            observers.Remove(alarmObserver);
        }
        public void NotifyObserver()
        {
            foreach (IAlarmObserver observer in observers)
            {
                observer.Update(alarmDateTime,alarmMessage);
            }
        }
    }
}
