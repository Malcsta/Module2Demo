/*
 * Name: Damien Altenburg
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 1.15.2024
 * Updated: 1.15.2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Appliances.Cooling;
using HumanResources.Payroll;

namespace Module2Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Declare a variable that can reference any type of employee.
            Employee thing;

            // 2. Define the variable from the previous step with a new instance of
            //    the HourlyEmployee class.
            thing = new SalariedEmployee("Joe", "Mama", "200000050", 20000);

            // 3. Print the employee from the previous step.
            Console.WriteLine(thing);

            HourlyEmployee hourlyBow = new HourlyEmployee(20, 50, "Joe", "Baba", "999999999");
            Console.WriteLine(hourlyBow.ToString());

            CommissionEmployee newFucker = new CommissionEmployee("dog", "shit", "999999999", 85000, 1.50F);
            Console.Write(newFucker.ToString());    

            // 4. Attempt to change the employee's wage to -15.45. When an
            //    ArgumentOutOfRangeException is raised, print the exception message
            //    to the console.

            // 5. Declare a variable of CommissionEmployee type.

            // 6. Define the variable from step 1 to a new instance of the BasePlusCommissionEmployee
            //    class.

            // 7. Set the commission employee's commission rate and gross sales.

            // 8. Set the commission employee's base salary.

            // 9. Print the commission employee to the console.

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
