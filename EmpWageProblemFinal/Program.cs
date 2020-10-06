using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace EmpWageProblemFinal
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Employee Wage Computation Program\n");
            EmployeeWageCalculator employee = new EmployeeWageCalculator("reliance", 10, 5, 2, 50, 20);
            EmployeeWageCalculator employee1 = new EmployeeWageCalculator();
            employee.EmpWageCalculator();
            employee1.EmpWageCalculator();

        }
 

       
    }
}
