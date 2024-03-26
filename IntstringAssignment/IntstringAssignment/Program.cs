using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntstringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {  //creating int list
            List<int> testScores = new List<int>() { 10, 25, 12, 74, 50, 121 };
            Console.WriteLine(" Pick a number to divide the list by.");
           
            //loop in try/catch block
            try
            {
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (int score in testScores)
                {
                    Console.WriteLine(score / numberOne);
                }

            }
            catch(DivideByZeroException) //continues program if user inputs zero
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch(FormatException) //continues program if user inputs anything else than a number
            {
                Console.WriteLine("Please enter a whole number");
            }
            

            Console.ReadLine();
           
        }
    }
}
