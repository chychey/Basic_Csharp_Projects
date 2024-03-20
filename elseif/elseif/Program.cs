using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "chy";

            if (name == "Kate")
            {
                Console.WriteLine("Your name is Kate");
            }
            else if (name == "Beth")
            {
                Console.WriteLine("Your name is not Kate");
            }
            else if (name == "Adam")
            {
                Console.WriteLine("Your name is Adam");
                Console.ReadLine();

                int age = 19;

                if (age < 21)
                {
                    Console.WriteLine("No , you may not purchase that bottle of wine.");
                }
                else
                {
                    Console.WriteLine("that will be $19.99");
                }
            }
        }

    }
}
