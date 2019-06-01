using System;
using System.Collections.Generic;

namespace assignment
{
    class TrainJourny : ITrainJourny
    {
        List<Station> _stations;
        Station _currentStation;
        Station _nextStation;

        public List<Station> stations { get { return _stations; } set { } }
        public Station currentStation { get { return _currentStation; } set { } }
        public Station nextStation { get { return _nextStation; } set { } }

        Station s = new Station("Rotterdam Centraal", "Amsterdam Centraal", new DateTime(2019, 2, 1, 10, 30, 02), new DateTime(2019, 2, 1, 10, 45, 00));
        Station s2 = new Station("Schiphol Airport", "Amsterdam Centraal", new DateTime(2019, 2, 1, 10, 30, 02), new DateTime(2019, 2, 1, 10, 45, 00));
        Station s3 = new Station("Amsterdam Centraal", "Rotterdam Centraal", new DateTime(2019, 2, 1, 10, 30, 02), new DateTime(2019, 2, 1, 10, 45, 00));

        public void AddStation(Station station)
        {
            stations.Add(station);
        }
        public void ChangeStation(Station station)
        {
            int indexOfStation = 0;
            foreach (var item in stations)
            {
                if (item == station)
                {
                    currentStation = station;
                    indexOfStation = stations.IndexOf(station);
                }
            }
            nextStation = stations[indexOfStation + 1];
        }
        public string CurrentStation(Station station)
        {
            string stationString = $"{station.name}, {station.arrivalTrack}, {station.departureTime}, {station.arrivalTime}";
            return stationString;
        }

        public void AddObserver(ITrainController observer)
        {
            
        }

        public void RemoveObserver(ITrainController observer)
        {
            
        }

        public void NotifyObserver(ITrainController observer)
        {
            
        }
    }
}
