
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment7
{
/*
    3.	Create a list of employees with following property EmpId, EmpName, EmpCity, EmpSalary.Populate some data
    Write a program for following requirement
    a.To display all employees data
    b.To display all employees data whose salary is greater than 45000
    c.To display all employees data who belong to Bangalore Region
    d.To display all employees data by their names is Ascending order
*/
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }

        public Employee(int empId, string empName, string empCity, double empSalary)
        {
            EmpId = empId;
            EmpName = empName;
            EmpCity = empCity;
            EmpSalary = empSalary;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {EmpId}, Name: {EmpName}, City: {EmpCity}, Salary: {EmpSalary}");
        }
    }

    class Program3
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"\n Enter details for employee {i + 1}:");

                Console.Write("Employee ID: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Employee Name: ");
                string empName = Console.ReadLine();

                Console.Write("Employee City: ");
                string empCity = Console.ReadLine();

                Console.Write("Employee Salary: ");
                double empSalary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(empId, empName, empCity, empSalary));
            }

            Console.WriteLine("\n All Employees:");
            foreach (var emp in employees)
            {
                emp.Display();
            }

            Console.WriteLine("\n Employees with salary greater than 45000:");
            var highSalaryEmployees = employees.Where(e => e.EmpSalary > 45000);
            foreach (var emp in highSalaryEmployees)
            {
                emp.Display();
            }

            Console.WriteLine("\n Employees from Bangalore:");
            var bangaloreEmployees = employees.Where(e => e.EmpCity == "Bangalore");
            foreach (var emp in bangaloreEmployees)
            {
                emp.Display();
            }

            Console.WriteLine("\n Employees sorted by Name (ascending):");
            var sortedEmployees = employees.OrderBy(e => e.EmpName);
            foreach (var emp in sortedEmployees)
            {
                emp.Display();
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }


}