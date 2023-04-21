using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            EmployeeService database = new EmployeeService();
            while (true)
            {
                Console.WriteLine("1. Create Employee");
                Console.WriteLine("2. Display Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Exit");
                Console.Write("\n Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        database.CreateEmployee();
                        break;
                    case "2":
                        database.DisplayEmployee();
                        break;
                    case "3":
                        database.DeleteEmployee();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
