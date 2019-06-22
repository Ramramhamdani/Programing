using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public interface ITrainController
    {
        void Next();
        void Previous();
        void ReturnJourny();
        Station GetCurrent();
        Station GetNext();
    }
}
