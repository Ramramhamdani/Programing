using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    interface ITrainJourny
    {
        void Show();
        void Previous();
        void Next();
       
        Station GetCurrentStation();

        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver(Station station);

    }
}
