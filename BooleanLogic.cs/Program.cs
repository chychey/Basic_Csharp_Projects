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
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Answer True/False");
            bool yesNo = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Have many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Qualified?");
            Console.WriteLine(age >= 16 && yesNo == false && tickets <= 3);
            Console.ReadLine();

            
            
                
        }
    }
}
           
      
