using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class course
    {
        public string name;
        public int grade;
        public PracticalGrade practical;
        public bool Passed()
        {
            if ((grade>55)&&((practical==PracticalGrade.good)||(practical==PracticalGrade.sufficient)))
            {
                return true;
            }
            return false;
        }
        public bool CumLaude()
        {
            if ((grade>=80)&&(practical==PracticalGrade.good))
            {
                return true;
            }
            return false;
        }
    }
    public enum PracticalGrade
    {
        None=0,Absent,Insufficient,sufficient,good
    }
    
}
