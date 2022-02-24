using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class EmployeeAttendence
    {
        public static int EmployeeWage()
        {
            //Constants

            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int IS_ABSENT = 0;
            const int EMP_RATE_PER_HOUR = 20;
            int workingHours = 8;

            //Variables
            int empHrs = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is doing parttime.");
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is doing fulltime");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent to the work");
                empHrs = 0;
            }
            int empWage = workingHours * EMP_RATE_PER_HOUR;
            return empWage;
        }
    }


}
