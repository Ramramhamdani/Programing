using System;

namespace Assignment_4
{
    class StandardDisplay : IObserver
    {
        private IGPSSystem gPSSystem;

        public StandardDisplay(IGPSSystem gPSSystem)
        {
            this.gPSSystem = gPSSystem;
            gPSSystem.AddObserver(this);
        }

        public void Update(double longtitude, double latitude)
        {
            Console.WriteLine("[Standard-display] longtitude: {0:0.00000}, latitude: {1:0.00000}",longtitude,latitude);

        }
    }
}
