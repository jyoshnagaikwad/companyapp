using companyapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyapp
{
    class EmployeeService
    {
        private List<Employee1> employees = new List<Employee1>();

        public void CreateEmployee()
        {
            Console.Write("Enter employee id: ");
            string id = Console.ReadLine();
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee designation: ");
            string designation = Console.ReadLine();
            Console.Write("Enter employee salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Employee1 employee = new Employee1 { Id = id, Name = name, Designation = designation, Salary = salary };
            employees.Add(employee);
        }

        public void DisplayEmployee()
        {
            Console.Write("Enter employee id: ");
            string id = Console.ReadLine();
            foreach (Employee1 employee in employees)
            {
                if (employee.Id == id)
                {
                    Console.WriteLine("- ID: " + employee.Id);
                    Console.WriteLine("- Name: " + employee.Name);
                    Console.WriteLine("- Designation: " + employee.Designation);
                    Console.WriteLine("- Salary: " + employee.Salary);
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }

        public void DeleteEmployee()
        {
            Console.Write("Enter employee id: ");
            string id = Console.ReadLine();
            foreach (Employee1 employee in employees)
            {
                if (employee.Id == id)
                {
                    employees.Remove(employee);
                    Console.WriteLine("Employee deleted successfully!");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }
    }
}