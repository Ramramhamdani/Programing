using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Station
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
