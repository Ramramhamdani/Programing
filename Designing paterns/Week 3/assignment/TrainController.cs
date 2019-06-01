using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class TrainController : ITrainController
    {
        public Station CurrentStation { get; }
        private TrainJourny trainJourny;

        public void Show()
        {
            trainJourny.CurrentStation(CurrentStation);
        }

        public void Next()
        {
            
        }

        public void Previos()
        {
            
        }

        public void AddObserver(ITrainJourny trainJourny)
        {
            
        }

        public void RemoveObserver(ITrainJourny trainJourny)
        {
            
        }
        public TrainController(TrainJourny trainJourny)
        {
            this.trainJourny = trainJourny;
        }
        
    }
}
