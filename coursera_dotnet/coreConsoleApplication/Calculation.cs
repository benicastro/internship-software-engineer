using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class Calculation
    {
        public void calculate()
        {
            int num1, num2, result = 0;
            try
            {
                Console.Write("Enter Number One: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Number Two: ");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Occurred.");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception Occurred.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurred.");
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("I will always execute.");
                Console.WriteLine(result);
            }
            
        }
    }
}
