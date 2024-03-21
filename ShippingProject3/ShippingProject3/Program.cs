using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("What is your package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {



                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                


                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("What is the package heigth?");
                int heigth = Convert.ToInt32(Console.ReadLine());
              


                int totalDimensions = (length + heigth + width);
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Dimensions are too big to be shipped via Package Express.");
                    }
                else
                {
                    int quote = (length * heigth * width) * packageWeight / 100;
                    Console.WriteLine("$" + quote + " This is your total cost of shipping");
                }

            }

            Console.ReadLine();



        }
    }
}

       
