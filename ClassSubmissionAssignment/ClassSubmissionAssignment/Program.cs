using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 MathOp1 = new Class1();//instantiate class
            Console.WriteLine("Please input a number.");//user enter number
            int userinput = Convert.ToInt32(Console.ReadLine());//
            MathOp1.Problem(userinput);//call method on number
            Console.ReadLine();
            Class2.StaticMethod();//calling staticmethod
            Console.ReadLine();
            Console.WriteLine("Please input a string.");
            string userinput2 = Console.ReadLine();
            string phrase = MathOp1.PlusMethod(userinput2, out int y);
            Console.WriteLine(phrase);
            Console.ReadLine();
            Console.WriteLine("Please input another string.");
            string userinput3 = Console.ReadLine();
            int phraseLength = MathOp1.PlusMethod(userinput3);
            Console.WriteLine("Your input was " + phraseLength + " characters long.");
            Console.ReadLine();
            //Console.WriteLine("Please enter you age");
            //bool isValid = int.TryParse(Console.ReadLine(), out int age);
            //string message = isValid ? $"You are {age} Years old" : "Please enter valid age";
            //Console.WriteLine(message);
            //Console.ReadLine();
            ////ReadKey();

        }
    }
}

