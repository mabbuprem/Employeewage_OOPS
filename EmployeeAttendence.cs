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
            const int WAGEPERHOUR = 20;

            int workingHours = 0;

            Random random = new Random();
            int employeeCheck = random.Next(0, 3);
            switch (employeeCheck)
            {

                case IS_PART_TIME:
                    Console.WriteLine("Employee is part-time working");
                    workingHours = 8;
                    break;
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is present");
                    workingHours = 8;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    workingHours = 0;
                    break;
            }


            int empWage = workingHours * WAGEPERHOUR;
            return empWage;
        }
    }


}