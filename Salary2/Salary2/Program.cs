using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary2
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
            int hourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked?");
            int work = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly rate?");
            int workRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeklyRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1");
            int income = hourRate * work * 52;
            Console.WriteLine(income);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2");
            int salary = workRate * weeklyRate * 52;
            Console.WriteLine(salary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more than Person 2? True/False");
            //bool yesNo = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(income > salary);
            Console.ReadLine();

        }
    }
}
