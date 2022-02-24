using System;
namespace EmpWage_OOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation problem solving with OOPS concept");
            EmployeeWage dmart = new EmployeeWage("Dmart", 20, 100, 20);
            EmployeeWage tata = new EmployeeWage("Tata", 25, 125, 30);
            dmart.GetEmpWage();
            Console.WriteLine(dmart.ToString());
            tata.GetEmpWage();
            Console.WriteLine(tata.ToString());

        }
    }
}
