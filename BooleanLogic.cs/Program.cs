using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);

            //Console.ReadLine();

            int yearsOld = 15;

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

           
            Console.WriteLine( age + "You are old enough");
            int yearsOld = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("you are not old enough!");
                Console.ReadLine();
            }
            
            

            Console.WriteLine("Have you ever had a DUI?");

            

            
            Console.ReadLine();
            Console.WriteLine("Have many speeding tickets do you have?");

            int num = 0;

            if (num <= 3)
            {
                Console.WriteLine("You don't have over the amount of tickets to not be eligible");
            }
            else
            {
                Console.WriteLine("You have too many tickets to be eligible");
                Console.ReadLine();
            }

            

            
            


           
        }
    }
}
