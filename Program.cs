using System;
namespace EmpWage_OOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation problem solving with OOPS concept");

            const int WAGE_PER_HOUR = 20;
            const int TOTAL_WORKING_DAYS = 20;
            const int MAX_HRS_WORKED = 100;
            int workingHours = 0;
            int totalWorkingHrs = 0;
            int workingDays = 0;
            int empTotalWage = 0;
            while (workingDays < TOTAL_WORKING_DAYS && totalWorkingHrs < MAX_HRS_WORKED)
            {
                workingHours = EmployeeAttendence.EmployeeWage();
                totalWorkingHrs = totalWorkingHrs + workingHours;

                int empWage = WAGE_PER_HOUR * workingHours;
                empTotalWage = empTotalWage + empWage;

                Console.WriteLine(empWage);
                workingDays++;

            }
            Console.WriteLine("Total working hours is :" + totalWorkingHrs);
            Console.WriteLine("Total employee wage is :" + empTotalWage);
        }
    }
}
