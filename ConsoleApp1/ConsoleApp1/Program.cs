using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 7;
            int total = num1 + num2;
            Console.WriteLine(total);
            Console.ReadLine();

        
        
            int num3 = 3;
            int num4 = 2;
            int difference = num3 - num4;
            Console.WriteLine(difference);
            Console.ReadLine();

            int num5 = 7;
            int num6 = 5;
            int product = num5 * num6;
            Console.WriteLine(product);
            Console.ReadLine();

            int num7 = 12;
            int num8 = 3;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int num9 = 23;
            int num10 = 46;
            int determine = num9 % num10;
            Console.WriteLine(determine);
            Console.ReadLine();

            double num11 = 7.0345672; //double is no more than 15-16 digits long
            float num12 = 5.9f; //float is no longer than 7 digits
            float math = (float)num11 + num12;
            Console.WriteLine(math);
            Console.ReadLine();

            decimal num13 = 8.3563272m;
            int num14 = 6;
            decimal equal = num13 + num14;
            Console.WriteLine(equal);
            Console.ReadLine();

            string firstname = "chyanne";
            string lastname = "Pilgreen";
            Console.WriteLine(firstname + lastname);
            Console.ReadLine();



        }
    }
}
