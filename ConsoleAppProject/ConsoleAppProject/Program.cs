using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drinks = { "Soda", "Juice", "Tea" };
            Console.WriteLine(drinks);
            Console.WriteLine("Please enter some text");
            string userinput = Console.ReadLine();
            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine(drinks[i]);
                drinks[i] += userinput;
                

            }
            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine(drinks[i]);
            }
            Console.WriteLine("Select 0 for Soda, 1 for Juice, and 2 for Tea.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput < drinks.Length)
            {

                Console.WriteLine(drinks[userInput]);

            }
            else
            {
                Console.WriteLine("Out of range.");
            }
            while (true)
            {
                //if (true)
                Console.WriteLine("What is your favorite drink?");

                //break; 
            }

        }
    }

}
