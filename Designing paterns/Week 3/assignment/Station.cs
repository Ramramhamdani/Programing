using System;

namespace assignment
{
    class Station
    {
        public string name;
        public string arrivalTrack;
        public DateTime arrivalTime;
        public DateTime departureTime;

        public Station(string name, string arrivalTrack, DateTime arrivalTime, DateTime departureTime)
        {
            this.name = name;
            this.arrivalTrack = arrivalTrack;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
        }
    }
}
