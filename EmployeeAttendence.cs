using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class CalculateWorkingHrs
    {
        int workingHrs = 0;

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
    }

    class EmployeeWage
    {
        public string companyName;
        public int maxDay;
        public int maxHrs;
        public int wagePerHr;

        public EmployeeWage(string companyName, int maxDay, int maxHrs, int wagePerHr)
        {
            this.companyName = companyName;
            this.maxDay = maxDay;
            this.maxHrs = maxHrs;
            this.wagePerHr = wagePerHr;
        }



        public void GetEmpWage()
        {
            int day = 0;
            int totalWorkingHrs = 0;
            int empTotalWage = 0;

            CalculateWorkingHrs calculateWorkingHrs = new CalculateWorkingHrs();

            while (day < maxDay && totalWorkingHrs <= maxHrs)
            {
                int workingHrs = calculateWorkingHrs.GetWorkingHrs();

                totalWorkingHrs = totalWorkingHrs + workingHrs;

                int empWage = wagePerHr * workingHrs;
                empTotalWage = empTotalWage + empWage;

                Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
                day++;
            }
            Console.WriteLine($"\n {companyName} employee details");
            Console.WriteLine("Total working hours is " + totalWorkingHrs);
            Console.WriteLine("Total employee wage is " + empTotalWage);


        }

    }

}