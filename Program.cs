using System;
namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation problem solving with OOPS concept");

            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.GetEmpWage();

        }
    }
}
