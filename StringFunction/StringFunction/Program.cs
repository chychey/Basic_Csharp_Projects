using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Chy";
            //string quote = "I said, \"Hello\", Chy. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:Users\Chy";

            //bool trueOrfalse = name.Contains("s");
            //trueOrfalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Chy");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
