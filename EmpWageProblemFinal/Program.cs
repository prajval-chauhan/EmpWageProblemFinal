using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace EmpWageProblemFinal
{
    class Program
    {
        //Constants
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOURS = 8;
        public const int PART_TIME_HOURS = 4;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;

        //Variables
        public int empHours = 0;
        public int empWagePerDay = 0;
        public int empWageTotal = 0;
        public int empWorkingDays = 0;
        public int empWorkingHoursTotal = 0;


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

        //Part time and full time wage computation
        public void EmpWageCalculator()
        {
            
            for(; ; )
            {
                if (empWorkingHoursTotal >= 100)
                {
                    Console.WriteLine("Maximum working hours limit reached");
                    break;
                }

                else if(empWorkingDays >= 20)
                {
                    Console.WriteLine("Maximum Working days limit reached");
                    break;
                }

                else if (empWorkingDays < 20 && empWorkingHoursTotal <= 100)
                {
                    int attendance = EmpAttendace();

                    switch (attendance)
                    {
                        case 1:
                            empHours = FULL_DAY_HOURS;
                            break;

                        case 2:
                            empHours = PART_TIME_HOURS;
                            break;
                        default:
                            empHours = 0;
                            break;
                    }
                    empWorkingDays = empWorkingDays + 1;
                    empWorkingHoursTotal = empWorkingHoursTotal + empHours;

                    if (empWorkingHoursTotal >100)
                    {
                        empWorkingHoursTotal = empWorkingHoursTotal - empHours;
                        empWorkingDays = empWorkingDays - 1;
                        continue;
                    }

                    empWagePerDay = empHours * EMP_WAGE_PER_HOUR;
                    empWageTotal = empWageTotal + empWagePerDay;



                    Console.WriteLine("Employee Wage for the day is : " + empWagePerDay);
                    Console.WriteLine("Employee working hours : " +empWorkingHoursTotal);
                    Console.WriteLine("Employee working days : " +empWorkingDays + "\n");
                }

            } 


            Console.WriteLine("Employee's Total Wage is : " + empWageTotal);
        }
    }
}
