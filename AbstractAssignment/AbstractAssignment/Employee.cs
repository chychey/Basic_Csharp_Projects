using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment 
{
    class Employee : Person, IQuittable1 //Derived class (employee) Inheriting from person
    {
        public void Quit();//implementing the SayName method

    }
            Console.WriteLine($"Employee's name: {FirstName} {LastName} has quit.");
        }
    

