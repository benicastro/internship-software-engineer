using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        // Properties when public
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Fields
        private double _salary { get; set; }

        // Define a method
        public void setSalary(double salary)
        {
            _salary = salary;
        }

        public double getSalary() 
        { 
            return _salary;
        }

        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
