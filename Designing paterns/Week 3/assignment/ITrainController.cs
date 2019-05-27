using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    interface ITrainController
    {
        void Show();
        void Next();
        void Previos();

        Station CurrentStation { get;}

        void AddObserver(ITrainJourny trainJourny);
        void RemoveObserver(ITrainJourny trainJourny);
    }
}
