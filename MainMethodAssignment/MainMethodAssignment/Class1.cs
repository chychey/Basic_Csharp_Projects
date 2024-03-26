using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Class1
    {
        public int methods1(int problem)  
        {
            return problem + 5;
        }
        public int methods1(decimal problem)
        {
            int newNumber = Convert.ToInt32(problem);
            return newNumber - 1;
        }
        public int methods1(string problem)
        {
            int newNumber = Convert.ToInt32(problem);
            return newNumber * 2;
        }

    }
}
