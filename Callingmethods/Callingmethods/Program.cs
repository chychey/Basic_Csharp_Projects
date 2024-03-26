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
            Console.WriteLine("Pick a number to do math operations on.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(methods.methods1(numberOne));
            Console.WriteLine(methods.methods2(numberOne));
            Console.WriteLine(methods.methods3(numberOne));
            Console.ReadLine();
        }
    }
}
