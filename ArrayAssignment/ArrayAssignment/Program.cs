using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dessert = { "cookie", "brownie", "cupcake" };
            Console.WriteLine("Select 0 for cookie, 1 for brownie, and 2 for cupcake.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput < dessert.Length)
            {

                Console.WriteLine(dessert[userInput]);

            }
            else
            {
                Console.WriteLine("Out of range.");
            }

            int[] number = { 1, 2, 3 };
            Console.WriteLine("Select 0 for 1, 1 for 2, and 2 for 3.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 < number.Length)
            {

                Console.WriteLine(number[number2]);

            }
            else
            {
                Console.WriteLine("Out of range.");
            }



            List<string> intList = new List<string>();
            intList.Add("pie");
            intList.Add("cake");
            intList.Add("ice cream");
            Console.WriteLine("Select 0 for Pie, 1 for cake, and 2 for ice cream.");

           
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number3 < intList.Count)
            {

                Console.WriteLine(intList[number3]);

            }
            else
            {
                Console.WriteLine("Out of range.");
            }
            Console.ReadLine();
        }
    }
}
