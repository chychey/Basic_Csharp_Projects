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

            Console.WriteLine("What is your age?");
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            Console.ReadLine();
            Console.WriteLine("Have many speeding tickets do you have?");
            Console.ReadLine();

            int age = 24;
            bool hasDUI = true || false;
            bool hasTickets = true || false;

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            bool canDrive = (age >= 18 && hasDUI && hasTickets);
            Console.WriteLine(canDrive);
            Console.ReadLine();
        }
    }
}
