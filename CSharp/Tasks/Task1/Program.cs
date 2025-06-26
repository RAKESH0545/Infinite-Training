using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /*Scenario: Employee Management System(Console-Based)*/
/*    -----------------------------------------------------
    You are tasked with developing a simple console-based Employee Management System using C# that allows users to manage a list of employees. Use a menu-driven approach to perform CRUD operations on a List<Employee>.

    Each Employee has the following properties:

    int Id

    string Name

    string Department

    double Salary
     Functional Requirements
    Design a menu that repeatedly prompts the user to choose one of the following actions:


    ===== Employee Management Menu =====
    1. Add New Employee
    2. View All Employees
    3. Search Employee by ID
    4. Update Employee Details
    5. Delete Employee
    6. Exit
    ====================================
    Enter your choice:

     Task:
    Write a C# program using:

    A class Employee with the above properties.

    A List<Employee> to hold all employee records.

    A menu-based loop to allow the user to perform the following:

    ✅ Expected Functionalities (CRUD)

    1.Prompt the user to enter details for a new employee and add it to the list.


    2.Display all employees 

    3.Allow searching an employee by Id and display their details.

    4.Search for an employee by Id, and if found, allow the user to update name, department, or salary.

    5.Search for an employee by Id and remove the employee from the list.

    6.Cleanly exit the program.

    Use Exception handling Mechanism*/
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }

    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("\n---- Employee Management Menu ----");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: AddEmployee();
                            break;

                        case 2: ViewEmployees();
                            break;

                        case 3: SearchEmployee();
                            break;

                        case 4: UpdateEmployee();
                            break;

                        case 5: DeleteEmployee();
                            break;

                        case 6: Console.WriteLine("Exiting...");
                            break;

                        default: Console.WriteLine("Invalid choice.");
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                    choice = 0;
                }

            } while (choice != 6);
        }

        static void AddEmployee()
        {
            Employee emp = new Employee();
            Console.Write("ID: "); emp.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: "); emp.Name = Console.ReadLine();
            Console.Write("Department: "); emp.Department = Console.ReadLine();
            Console.Write("Salary: "); emp.Salary = double.Parse(Console.ReadLine());
            employees.Add(emp);
            Console.WriteLine("Employee added.");
        }

        static void ViewEmployees()
        {
            foreach (var e in employees)
                Console.WriteLine($"ID:{e.Id}, Name:{e.Name}, Dept:{e.Department}, Salary:{e.Salary}");
        }

        static void SearchEmployee()
        {
            Console.Write("Enter ID to search: ");
            int id = int.Parse(Console.ReadLine());
            var e = employees.Find(x => x.Id == id);
            if (e != null)
                Console.WriteLine($"ID:{e.Id}, Name:{e.Name}, Dept:{e.Department}, Salary:{e.Salary}");
            else
                Console.WriteLine("Employee not found.");
        }

        static void UpdateEmployee()
        {
            Console.Write("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var e = employees.Find(x => x.Id == id);
            if (e != null)
            {
                Console.Write("New Name: "); e.Name = Console.ReadLine();
                Console.Write("New Department: "); e.Department = Console.ReadLine();
                Console.Write("New Salary: "); e.Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Employee updated.");
            }
            else
                Console.WriteLine("Employee not found.");
        }

        static void DeleteEmployee()
        {
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            var e = employees.Find(x => x.Id == id);
            if (e != null)
            {
                employees.Remove(e);
                Console.WriteLine("Employee deleted.");
            }
            else
                Console.WriteLine("Employee not found.");
        }
    }

}
