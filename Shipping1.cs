using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("What is your package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            string solve = packageWeight >= 50 ? "Your Package is too heavy to ship" : "Ok move to the next step to complete shipping";
            Console.WriteLine(solve);

            Console.WriteLine("What is the package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(width);
            Console.ReadLine();

            Console.WriteLine("What is the package length?");
            int dimensions = Convert.ToInt32(Console.ReadLine());
            string answer = dimensions >= 50 ? "Your Package is too big to ship" : "Ok move to the next step to complete shipping";
            Console.WriteLine(answer);
            Console.ReadLine();

            
            Console.WriteLine(dimensions * packageWeight * width);
            double Result = dimensions * packageWeight * width / 100;
            int outcome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(outcome + Result + "This is your total cost of shipping");
            Console.ReadLine();


           
        }
    }
}
