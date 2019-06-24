using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public interface ILife
    {
        bool CellShouldLive(bool livingCell, int neighbourCount);
    }
}
