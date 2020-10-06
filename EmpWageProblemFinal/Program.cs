using System;
using System.Security.Cryptography.X509Certificates;

namespace EmpWageProblemFinal
{
    class Program
    {
        //Constants
        public const int empWagePerHour = 20;
        public const int fullDayHours = 8;
        public const int partTimeHours = 4;

        //Variables
        public int empHours = 0;
        public int empWagePerDay = 0;
        public int empWageTotal = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program\n");
            Program Employee = new Program();
            Employee.EmpWageCalculator();


            

        }
        //Employee Attendance Check
        public int EmpAttendace()
        {
            
            Random randomNum = new Random();
            int attendance = randomNum.Next(0, 3);

            switch (attendance)
            {
                case 1:
                    Console.WriteLine("Employee is present");
                    break;
                case 2:
                    Console.WriteLine("Employee is working part time");
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;               
            }
            return attendance;
        }

        public void EmpWageCalculator()
        {

            int attendance = EmpAttendace();
            if (attendance == 1)
                empHours = fullDayHours;
            else if (attendance == 2)
                empHours = partTimeHours;
            else
                empHours = 0;

            empWagePerDay = empHours * empWagePerHour;
            empWageTotal = empWageTotal + empWagePerDay;

            Console.WriteLine("Employee Wage for the day is : " +empWagePerDay);
            Console.WriteLine("Employee's Total Wage is : " +empWageTotal);
        }
    }
}
