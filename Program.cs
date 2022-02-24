using System;
namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation problem solving with OOPS concept");

            EmployeeWage employeeWage1 = new EmployeeWage("Dmart", 20, 100, 20);
            EmployeeWage employeeWage2 = new EmployeeWage("Tata", 25, 125, 30);
            employeeWage1.GetEmpWage();
            employeeWage2.GetEmpWage();
        }
    }
}
