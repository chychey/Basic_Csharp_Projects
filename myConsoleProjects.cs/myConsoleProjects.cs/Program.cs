using System;


namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy"); //in console The tech academy appears//
            string School = Console.ReadLine();    //makes sure program keeps going
            Console.WriteLine(" Student Daily Report");
            string report = Console.ReadLine();

            Console.WriteLine("what is your name?"); //data//
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?: "); //interacting with console//
            string courseName = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string posExperience = Console.ReadLine();
            Console.WriteLine("What page number?");

            
            int pageNumber = Convert.ToInt32(Console.ReadLine());   
            //string pageNumber = Console.ReadLine();
            //int pageNumberInt = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer True or False");
            bool yesNo = Convert.ToBoolean(Console.ReadLine());
            

            Console.WriteLine("Is there any other feedback? Please be specific");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            int studyHour = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Thank you for your answers!"); //ends console//
            string thankYou = Console.ReadLine();

        

            
            
           
            
            
        }
    }
}
