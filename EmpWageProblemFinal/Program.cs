using System;
using System.Security.Cryptography.X509Certificates;

namespace EmpWageProblemFinal
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program\n");
            Program empAtt = new Program();
            empAtt.EmpAttendace();


            

        }
        //Employee Attendance Check
        public void EmpAttendace()
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
        }
    }
}
