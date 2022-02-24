using System;
namespace EmpWage_OOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation problem solving with OOPS concept");

            EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder(4);
            employeeWageBuilder.AddEmployeeInfo("Tata", 20, 100, 20);
            employeeWageBuilder.AddEmployeeInfo("Dmart", 25, 125, 25);
            employeeWageBuilder.AddEmployeeInfo("Reliance", 30, 140, 35);
            employeeWageBuilder.AddEmployeeInfo("BigBazar", 23, 110, 22);
            employeeWageBuilder.CalWage();
        }
    }
}
