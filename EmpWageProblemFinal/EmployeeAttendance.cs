using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblemFinal
{
    class EmployeeAttendance
    {
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
    }
}
