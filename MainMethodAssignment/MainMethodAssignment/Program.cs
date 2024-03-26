using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOp = new Class1();
            Console.WriteLine(mathOp.methods1(3));
            Console.WriteLine(mathOp.methods1(6.5m));
            Console.WriteLine(mathOp.methods1("8"));
            Console.ReadLine();
            
        }
    }
}
