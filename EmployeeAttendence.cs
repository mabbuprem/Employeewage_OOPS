using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        int workingHrs = 0;
        int empTotalWage = 0;
        int MAXDAYS = 20;
        int MAXHRS = 100;
        int WAGEPERHRS = 20;

        public int GetWorkingHrs()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            //Constants
            const int ABSENT = 0;
            const int FULLTIME = 1;

            switch (empCheck)
            {
                case ABSENT:
                    workingHrs = 0;
                    break;

                case FULLTIME:
                    workingHrs = 8;
                    break;

                default:
                    workingHrs = 4;
                    break;
            }

            return workingHrs;
        }

        public void GetEmpWage()
        {
            int day = 0;
            int totalWorkingHrs = 0;

            EmployeeWage empWage1 = new EmployeeWage();

            while (day < MAXDAYS && totalWorkingHrs <= MAXHRS)
            {
                workingHrs = empWage1.GetWorkingHrs();

                totalWorkingHrs = totalWorkingHrs + workingHrs;

                int empWage = WAGEPERHRS * workingHrs;
                empTotalWage = empTotalWage + empWage;

                Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
                day++;
            }

            Console.WriteLine("\nTotal working hours is " + totalWorkingHrs);
            Console.WriteLine("Total employee wage is " + empTotalWage);

        }

    }

}