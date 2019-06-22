using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class TrainController : ITrainController
    {
        TrainJourny TrainJourny;
        public TrainController()
        {
            TrainJourny = new TrainJourny();
        }

        public Station GetCurrent()
        {
            return TrainJourny.GetCurrentStation();
        }

        public Station GetNext()
        {
            return TrainJourny.GetNext();
        }

        public void Next()
        {
            TrainJourny.NextStation();
        }

        public void Previous()
        {
            TrainJourny.Previous();
        }

        public void ReturnJourny()
        {
            TrainJourny.ReturnJourny();
        }
    }
}
