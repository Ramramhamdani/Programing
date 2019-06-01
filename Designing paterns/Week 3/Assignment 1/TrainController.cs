using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class TrainController : ITrainController
    {
        private ITrainJourny trainJourny;
        public TrainController(ITrainJourny trainJourny)
        {
            this.trainJourny = trainJourny;
        }

        public void Next()
        {
            trainJourny.Next();
        }

        public void Previous()
        {
            trainJourny.Previous();
        }

        public void Show()
        {
            trainJourny.Show();
        }
    }
}
