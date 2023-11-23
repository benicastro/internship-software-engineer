using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class User
    {
        private string name;
        private string companyName;
        private int age;
        private string City {  get; set; }

        public User() 
        {
            companyName = "BZC";
        }
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        } 

        public string CompanyName
        {
            get { return companyName; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                    throw new ArgumentException("Invalid Age");
                age = value;

            }
        }
    }
}
