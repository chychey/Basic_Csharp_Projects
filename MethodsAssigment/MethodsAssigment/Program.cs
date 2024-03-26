using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOp = new Class1(); //instantiate class
            Console.WriteLine("Input two numbers, one at a time. You do not need to enter anything for the second number");
            int numberOne = Convert.ToInt32(Console.ReadLine()); //creating input for user to execute the integer
            try //putting option to solve both numbers user input or default to first number they input
            {
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(mathOp.methods1(numberOne, numberTwo));//calling class (mathOp) and method(method1), + getting user input(numberOne,numberTwo)
            }
            catch
            {
                Console.WriteLine(mathOp.methods1(numberOne));//if user does not put in second number this catches it and solves (numberOne)
            }
            Console.ReadLine();  
        }
        
       
    }
}
