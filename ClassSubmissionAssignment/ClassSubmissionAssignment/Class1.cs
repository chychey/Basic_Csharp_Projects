using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Class1
    {
        public void Problem(int number1)//void method output integer
        {
            number1 /= 2;
            Console.WriteLine("This is your number divided by 2: " + number1); //method divide data by 2


        }
        public string PlusMethod(string x, out int y)//method with output parameters
        {
            y = x.Length;
            string result = "Your string is " + y + " Characters long";
            return result; 
        }
        public int PlusMethod(string x)//overload method (PlusMethod)
        {
            int count = x.Length;
            return count;
        }
    }
}
