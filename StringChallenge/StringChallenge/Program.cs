using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "<Type name here>";
            username = username.ToUpper();
            string dataString = DateTime.Today.ToShortDateString();
            

            string str = "Hello " + username + ". Today is " + dataString + ".";
            System.Console.WriteLine(str);

            str += " How are you today?";
            System.Console.WriteLine(str);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("I said, \"Hello\", Chy. \n I am well. \n \t How about you?. \n I love life. " );
            

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
