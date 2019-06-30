using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class GPSController : IGPSController
    {
        IGPSSystem gPSSystem;
        public void UpdatePosition()
        {
            gPSSystem.UpdatePosition();
        }
        public GPSController(IGPSSystem gPSSystem)
        {
            this.gPSSystem = gPSSystem;
        }
    }
}
