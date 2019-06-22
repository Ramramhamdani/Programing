using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class TrainJourny : ITrainJourny
    {
        List<IObserver> observers;
        List<Station> stations;
        Station currentStaion;
        Station nextStaion;

        public TrainJourny()
        {
            observers = new List<IObserver>();
            stations = new List<Station>();
            Station station = new Station($"{Station.Stations.den_haag}", 3, new DateTime(2019, 2, 1, 10, 30, 02), new DateTime(2019, 2, 1, 10, 45, 00));
            Station station2 = new Station($"{Station.Stations.haarlem}", 3, new DateTime(2019, 2, 1, 11, 00, 02), new DateTime(2019, 2, 1, 11, 40, 00));
            Station station3 = new Station($"{Station.Stations.rotterdam}", 3, new DateTime(2019, 2, 1, 12, 30, 02), new DateTime(2019, 2, 1, 13, 45, 00));
            stations.Add(station);
            stations.Add(station2);
            stations.Add(station3);
            currentStaion = stations[0];
            nextStaion = stations[1];
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public Station GetCurrentStation()
        {
            return currentStaion;
        }

        public Station GetNext()
        {
            return nextStaion;
        }

        public void NextStation()
        {
            int ind = stations.IndexOf(currentStaion);
            if (ind<stations.Count-1)
            {
                currentStaion = stations[ind + 1];
                if (ind<=stations.Count-3 )
                {
                    nextStaion = stations[ind + 2];
                }
            }
            NotifyObserver();
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.UpdateScreen();
            }
        }

        public void Previous()
        {
            int ind = stations.IndexOf(currentStaion);
            if (ind > 0)
            {
                currentStaion = stations[ind - 1];
                if (ind >= 2)
                {
                    nextStaion = stations[ind - 2];
                }
            }
            NotifyObserver();
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void ReturnJourny()
        {
            List<Station> returnJourny = new List<Station>();
            int n = 0;
            for (int i = stations.Count; i < 0; i--)
            {
                returnJourny[n] = stations[i];
                n++;
            }
            stations = returnJourny;
            NotifyObserver();
        }
    }
}
