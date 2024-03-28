using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjects
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Employee's name: {FirstName}{LastName}"); 

            
        }
    }
}
