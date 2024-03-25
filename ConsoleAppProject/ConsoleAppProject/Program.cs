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
            //part one
            string[] drinks = { "Soda", "Juice", "Tea" };
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
            //part 2
            while (true)
            {
                if (true)
                Console.WriteLine("What is your favorite drink?");

                break; 
            }
            //part three
            for (int i = 0; i < 3; i++)
			{
                Console.WriteLine(i);

			}
            for (int i = 0; i <= 3; i++)
			{
                Console.WriteLine(i);

			}
            //part 4
            List<string> aList = new List<string>() { "truck", "pig", "shoes", "baseball"};
            Console.WriteLine("Enter text to seach for something in the list");
            string userinput2 = Console.ReadLine();
            for (int i = 0; i < aList.Count; i++)
            {
                if (aList.Contains(userinput2)) { 
                if(userinput2 == aList[i])
                    {
                    Console.WriteLine(aList[i] + " index is " + i);
                        break;
                }
                }
                else
                {
                    Console.WriteLine("users input is not on the list.");
                }
            }

            //part 5
             List<string> aList2 = new List<string>() { "truck", "pig", "shoes", "pig", "baseball"};
            Console.WriteLine("Enter text to seach for something in the list");
            string userinput3 = Console.ReadLine();
            for (int i = 0; i < aList2.Count; i++)
            {
                if (aList.Contains(userinput3)) { 
                if(userinput3 == aList2[i])
                    {
                    Console.WriteLine(aList2[i] + " index is " + i);
                        
                }
                }
                else
                {
                    Console.WriteLine("users input is not on the list.");
                }
            }
            //part 6
            List<string> aList3 = new List<string>() { "truck", "pig", "shoes", "pig", "baseball"};
            List<string> dupList = new List<string>();
            foreach (var item in aList3)
	        {
                if (dupList.Contains(item))
                {
                    Console.WriteLine(item + " is a duplicate");
                }
                else
                {
                    Console.WriteLine(item + " is unique");
                    dupList.Add(item);
                }


	        }

            
            
            
            
            
            
            
            
            
            Console.ReadLine();
                    

        }
    }

}
