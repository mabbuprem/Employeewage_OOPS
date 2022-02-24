using System;
namespace EmpWage_OOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation problem solving with OOPS concept");
            int day = 0;
            int empTotalWage = 0;
            int MAXDAYS = 20;

            while (day < MAXDAYS)
            {
                int empWage = EmployeeAttendence.EmployeeWage();
                empTotalWage = empTotalWage + empWage;
                Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
                day++;
            }
            Console.WriteLine("\nEmployee total wage is " + empTotalWage);

        }
    }
}
