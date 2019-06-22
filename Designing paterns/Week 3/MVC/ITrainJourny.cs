using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public interface ITrainJourny
    {
        void NextStation();
        void Previous();
        void ReturnJourny();


        Station GetCurrentStation();
        Station GetNext();

        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
