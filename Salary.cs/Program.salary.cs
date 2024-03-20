using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly rate?");
            Console.ReadLine();
            int rate = 12 * 3;
            Console.WriteLine(rate);
            Console.ReadLine();
            Console.WriteLine("Hours worked?");
            int work = 10 * 3;
            Console.WriteLine(work);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly rate?");
            Console.ReadLine();
            int product = 5 * 8;
            Console.WriteLine(product);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            Console.ReadLine();
            int weekly = 5 * 6;
            Console.WriteLine(weekly);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1");
            int income = 36 * 30 * 365;
            Console.WriteLine(income);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2");
            Console.ReadLine();
            int build = 40 * 30 * 365;
            Console.WriteLine(build);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.ReadLine();


            bool trueOrFalse = 394200 > 480000;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();





        }
    }
}
