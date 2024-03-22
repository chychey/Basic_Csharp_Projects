using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            while (i < 300)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Guess my favorite number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 222;

            

            do
            {
                switch (number)
                {
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4. Try again.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 222:
                        Console.WriteLine("You gussed the number 222. That is my favorite number!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.Read());
                        break;
                }

            }
            while (!isGuessed);
            

            Console.Read();
        }
    }
}
