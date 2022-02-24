using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class EmployeeAttendence
    {


        public static void EmployeeAttendencee()
        {
            const int fullTime = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == fullTime)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }


}
