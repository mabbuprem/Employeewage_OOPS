using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    class EmployeeWage

    {
        public string companyName;
        public int maxDay;
        public int maxHrs;
        public int wagePerHr;
        int totalWage = 0;

        public EmployeeWage(string companyName, int maxDay, int maxHrs, int wagePerHr)
        {
            this.companyName = companyName;
            this.maxDay = maxDay;
            this.maxHrs = maxHrs;
            this.wagePerHr = wagePerHr;
        }

        public void SetTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public string ToString()
        {
            return "\nTotal employee wage for company " + companyName + " is " + totalWage;

        }

    }
}