using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    enum Weekdays: byte
    {
        Monday,
        Tuesday, 
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class EnumDemo
    {
        public void display()
        {
            Console.WriteLine(Weekdays.Monday);
            int day = (int)DayOfWeek.Monday;
            Console.WriteLine(Weekdays.Monday + ":" + day);

            Console.WriteLine(Weekdays.Tuesday);

            Console.WriteLine(Weekdays.Wednesday);
        }
    }
}
