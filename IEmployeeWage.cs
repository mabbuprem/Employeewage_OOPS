using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    interface IEmployeeWage
    {
        public void AddEmployeeInfo(string companyName, int maxDay, int maxHrs, int wagePerHr);
        public int GetEmpWage(EmployeeWage employeeWages);
        public void CalWage();

    }
}