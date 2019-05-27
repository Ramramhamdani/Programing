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

        public void Show()
        {
            
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Previos()
        {
            throw new NotImplementedException();
        }

        public void AddObserver(ITrainJourny trainJourny)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(ITrainJourny trainJourny)
        {
            throw new NotImplementedException();
        }
        
    }
}
