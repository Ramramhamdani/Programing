using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    interface IAlarmSystem
    {
        void ActivateAlarm(DateTime dateTime , string msg);
        void AddObserver(IAlarmObserver alarmObserver);
        void RemoveObserver(IAlarmObserver alarmObserver);
    }
}
