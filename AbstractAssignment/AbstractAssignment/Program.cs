﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee //Instantiate an Employee object
            {
                FirstName = "Sample",
                LastName = "Student",
            };

            employee.SayName(); //Call SayName method

        }

    }

}
        


    

