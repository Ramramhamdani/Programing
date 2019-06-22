using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Station
    {
        public enum Stations { den_haag=1, haarlem, rotterdam}
        public string name;
        public int arrivalTrack;
        public DateTime arrivalTime;
        public DateTime departureTime;

        
        public Station(string name, int arrivalTrack, DateTime arrivalTime,DateTime departureTime)
        {
            this.name = name;
            this.arrivalTrack = arrivalTrack;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
        }
    }

}
