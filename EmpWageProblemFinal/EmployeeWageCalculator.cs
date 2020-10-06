using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblemFinal
{
    class EmployeeWageCalculator
    {
        //Constants
        public int EMP_WAGE_PER_HOUR = 20;
        public int FULL_DAY_HOURS = 8;
        public int PART_TIME_HOURS = 4;
        public int MAX_WORKING_DAYS = 20;
        public int MAX_WORKING_HOURS = 100;

        //Variables
        public int empHours = 0;
        public int empWagePerDay = 0;
        public int empWageTotal = 0;
        public int empWorkingDays = 0;
        public int empWorkingHoursTotal = 0;
        public string companyName = "default";

        //Default Constructor
        public EmployeeWageCalculator()
        {

        }


        //Construction Declaration to calculate the employee wages for different companies
        public EmployeeWageCalculator (string companyName, int wagePerHour, int fullDayHours, int partTimeHours, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.EMP_WAGE_PER_HOUR = wagePerHour;
            this.FULL_DAY_HOURS = fullDayHours;
            this.PART_TIME_HOURS = partTimeHours;
            this.MAX_WORKING_DAYS = maxWorkingDays;
            this.MAX_WORKING_HOURS = maxWorkingHours;
        }

        EmployeeAttendance call = new EmployeeAttendance();

        //Part time and full time wage computation
        public void EmpWageCalculator()
        {

            for (; ; )
            {
                if (empWorkingHoursTotal >= 100)
                {
                    Console.WriteLine("Maximum working hours limit reached");
                    break;
                }

                else if (empWorkingDays >= 20)
                {
                    Console.WriteLine("Maximum Working days limit reached");
                    break;
                }

                else if (empWorkingDays < 20 && empWorkingHoursTotal <= 100)
                {
                    int attendance = call.EmpAttendace();

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

                    if (empWorkingHoursTotal > 100)
                    {
                        empWorkingHoursTotal = empWorkingHoursTotal - empHours;
                        empWorkingDays = empWorkingDays - 1;
                        continue;
                    }

                    empWagePerDay = empHours * EMP_WAGE_PER_HOUR;
                    empWageTotal = empWageTotal + empWagePerDay;



                    Console.WriteLine("Employee Wage for the day is : " + empWagePerDay);
                    Console.WriteLine("Employee working hours : " + empWorkingHoursTotal);
                    Console.WriteLine("Employee working days : " + empWorkingDays + "\n");
                }

            }


            Console.WriteLine("Employee's Total Wage for the company "+companyName +" is : " + empWageTotal);
        }
    }
}
