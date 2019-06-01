using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class TrainJourny : ITrainJourny
    {
        List<Station> stations;
        Station currentStation;
        Station nextStation;
        Station previousStation;

        private List<IObserver> observers;

        public TrainJourny()
        {
            Station s = new Station("Rotterdam Centraal", "Amsterdam Centraal", new DateTime(2019, 2, 1, 10, 30, 02), new DateTime(2019, 2, 1, 10, 45, 00));
            Station s2 = new Station("Schiphol Airport", "Amsterdam Centraal", new DateTime(2019, 2, 1, 10, 30, 02), new DateTime(2019, 2, 1, 10, 45, 00));
            Station s3 = new Station("Amsterdam Centraal", "Rotterdam Centraal", new DateTime(2019, 2, 1, 10, 30, 02), new DateTime(2019, 2, 1, 10, 45, 00));
            stations = new List<Station>();
            stations.Add(s);
            stations.Add(s2);
            stations.Add(s3);
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public Station GetCurrentStation()
        {
            return currentStation;
        }
        public void Show()
        {
            NotifyObserver(currentStation);
        }
        public void Next()
        {
            int n = stations.IndexOf(currentStation);
            nextStation = stations[n++];
            NotifyObserver(nextStation);
        }
        public void Previous()
        {
            int n = stations.IndexOf(currentStation);
            previousStation = stations[n--];
            NotifyObserver(previousStation);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObserver(Station station)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(station);
            }
        }

        
        //public void Update()
        //{
        //    // display station
        //    Console.WriteLine(string.Format($"{currentStation.name}: {currentStation.arrivalTime}: {currentStation.arrivalTrack}" +
        //        $": {currentStation.departureTime}"));
        //}
    }
}
