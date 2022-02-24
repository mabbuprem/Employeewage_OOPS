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
            const int IS_FULL_TIME = 1;
            const int IS_ABSENT = 0;
            const int EMP_RATE_PER_HOUR = 20;


            //Variables
            int empHrs = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is doing fulltime");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent to the work");
                empHrs = 0;
            }

            // empHrs = 0;

            int empWage = EMP_RATE_PER_HOUR * empHrs;
            return empWage;

        }
    }
}
