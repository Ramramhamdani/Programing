using System.Collections.Generic;

namespace assignment
{
    interface ITrainJourny
    {
        List<Station> stations { get; set; }
        Station currentStation { get; set; }
        Station nextStation { get; set; }

        void AddStation(Station station);
        void ChangeStation(Station station);
        string CurrentStation(Station station);

        void AddObserver(ITrainController observer);
        void RemoveObserver(ITrainController observer);
        void NotifyObserver(ITrainController observer);
    }
}
