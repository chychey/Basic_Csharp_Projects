using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsestatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int packageWeight = 50;
            int packageLength = 25;
            if (packageWeight > 40 && packageLength > 20)
            {
                Console.WriteLine("this package is too big to ship.");
                Console.ReadLine();
            }

        }
    }
}
