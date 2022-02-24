using System;
namespace EmpWage_OOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation problem solving with OOPS concept");
            int empWage = EmployeeAttendence.EmployeeWage();
            Console.WriteLine(empWage);

        }
    }
}
