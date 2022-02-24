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
            const int IS_PART_TIME = 2;
            const int IS_ABSENT = 0;
            Console.WriteLine($"Employee Wage Calculator");
            int workingHr = 1;
            const int perHrSalary = 20;

            Random random = new Random();
            int present = (random.Next(0, 3));

            switch (present)
            {

                case IS_PART_TIME:
                    Console.WriteLine("Employee is parttime");
                    workingHr = 4;
                    break;

                case IS_FULL_TIME:
                    Console.WriteLine("Employee is fulltime");
                    workingHr = 8;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    workingHr = 0;
                    break;
            }

            int empWage = perHrSalary * workingHr;
            return empWage;
        }
    }


}
