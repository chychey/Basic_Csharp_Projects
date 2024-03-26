using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOp = new Class1();
            Console.WriteLine("Please input a number.");
            int userinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input another number.");
            int userinput2 = Convert.ToInt32(Console.ReadLine());
            mathOp.Problem(userinput, userinput2);
            Console.ReadLine();
            mathOp.Problem(number1: 2, number2: 3);
            Console.ReadLine();
        }
        
    }
}
