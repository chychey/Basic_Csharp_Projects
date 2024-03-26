using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssigment
{
    public class Class1
    {
        public int methods1(int problem, int problem2 = 3)// two integers as parameters, default if user does not put second number is 3
        {
            return problem + problem2; //math operation from user input
            
        }
        public int methods2(int problem)//extra code that is not used in this assignment
        {
            return problem - 2;
        }
    }
}
