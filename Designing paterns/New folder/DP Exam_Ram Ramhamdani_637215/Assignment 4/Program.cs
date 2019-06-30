using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        private void Start()
        {
            // create GPS system
            IGPSSystem gps = new GlobalPositioningSystem();

            // create controller
            IGPSController controller = new GPSController(gps);

            // create displays
            IObserver display = new SimpleDisplay(gps);
            IObserver display2 = new StandardDisplay(gps);

            // update the GPS system a few times (for testing)
            controller.UpdatePosition(); Console.WriteLine();
            controller.UpdatePosition(); Console.WriteLine();
        }
    }
}
