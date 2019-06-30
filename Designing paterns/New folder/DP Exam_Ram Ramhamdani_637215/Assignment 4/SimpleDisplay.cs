using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class SimpleDisplay : IObserver
    {
        private IGPSSystem gpsSystem;
        public void Update(double longtitude, double latitude)
        {
            Console.WriteLine("[simple-display] {0:0.00000}, {1:0.00000}",longtitude,latitude);
        }
        public SimpleDisplay(IGPSSystem gPSSystem)
        {
            gpsSystem = gPSSystem;
            gpsSystem.AddObserver(this);
        }
    }
}
