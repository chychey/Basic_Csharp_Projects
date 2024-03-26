using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callingmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number to do math operations on."); //getting user input to return an integer
            int numberOne = Convert.ToInt32(Console.ReadLine()); //user inputs number to return the methods I set up in class
            Console.WriteLine(methods.methods1(numberOne)); //returning method1(+5)
            Console.WriteLine(methods.methods2(numberOne)); //returning method2(/2)
            Console.WriteLine(methods.methods3(numberOne)); //returning method3(-7)
            Console.ReadLine(); //stops console from closing until end of program
        }
    }
}
