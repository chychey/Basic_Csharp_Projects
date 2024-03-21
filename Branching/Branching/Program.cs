
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have a great fav number." : "You do not have a great fav number.";

            Console.WriteLine(result);
            Console.ReadLine();



            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi," + name + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("It is colder than room temp.");

            }
            else
            {
                Console.WriteLine("uhh..something happened");
            }


            int currentTemperature = 80;
            int roomTemperature = 70;

            string comparisonResult = currentTemperature == roomTemperature ? "It is room." : "It is not room temp.";
            
            Console.WriteLine(comparisonResult);
            Console.ReadLine();
            if (currentTemperature == roomTemperature)

        //    int currentTemperature = 70;
        //    int roomTemperature = 70;

        //    if (currentTemperature == roomTemperature)
        //    {
        //        Console.WriteLine("It is exactly room temperature.");
        //    }
        //    else if (currentTemperature > roomTemperature)
        //    {
        //        Console.WriteLine("It is warmer than room temperature.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("It is not exactly room temperature ");
        //    }
            Console.ReadLine();
        }
            
    }
}
