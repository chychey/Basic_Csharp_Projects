using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Employee : Person //Derived class (employee) Inheriting from person
    {
        //implementing the SayName method
        public override void SayName()
        {
            Console.WriteLine($"Emplyee's name: {FirstName} {LastName}");
        }
    }
}
