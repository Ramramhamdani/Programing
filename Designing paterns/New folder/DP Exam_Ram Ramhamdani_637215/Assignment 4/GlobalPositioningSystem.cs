using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class GlobalPositioningSystem : IGPSSystem
    {
        double latitude;
        double longtitude;
        Random rnd;

        public double CurrentLatitude { get { return latitude; } set { latitude = value; } }
        public double CurrentLongtitude { get { return longtitude; } set { longtitude = value; } }

        List<IObserver> Displays;

        public GlobalPositioningSystem()
        {
            Displays = new List<IObserver>();
            rnd = new Random();
        }

        public void AddObserver(IObserver observer)
        {
            Displays.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Displays.Remove(observer);
        }

        public void UpdatePosition()
        {
            latitude = rnd.Next(0, 180)*1.10345;
            longtitude = rnd.Next(0, 361)*1.12345;
            NotifyObsevers();
        }
        public void NotifyObsevers()
        {
            foreach (IObserver observer in Displays)
            {
                observer.Update(longtitude,latitude);
            }
        }
    }
}
