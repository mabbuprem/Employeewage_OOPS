using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class EmployeeWage
    {
        public string companyName;
        public int maxDay;
        public int maxHrs;
        public int wagePerHr;
        int empTotalWage = 0;

        public EmployeeWage(string companyName, int maxDay, int maxHrs, int wagePerHr)
        {
            this.companyName = companyName;
            this.maxDay = maxDay;
            this.maxHrs = maxHrs;
            this.wagePerHr = wagePerHr;
        }


        public void GetEmpWage()
        {
            int workingHrs = 0;
            int day = 0;
            int totalWorkingHrs = 0;


            while (day < maxDay && totalWorkingHrs <= maxHrs)
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

                totalWorkingHrs = totalWorkingHrs + workingHrs;

                int empWage = wagePerHr * workingHrs;
                empTotalWage = empTotalWage + empWage;

                //Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
                day++;
            }

        }

        public string ToString()
        {
            return "\nTotal employee wage for company " + companyName + " is " + empTotalWage;

        }

    }
}