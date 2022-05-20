using System;
using System.Collections.Generic;
namespace CourseList {
    class Program {

        static void ListEmployees(List<Employee> employees) {
            for (int i = 0; i < employees.Count; i++) {
                Console.Write($"Employee #{i + 1}:");
                Console.WriteLine(employees[i]);
            }
        }
        static void Main(string[] args) {
            Console.Write("How many employees will be registred? ");
            int count = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < count; i++) {
                Console.Write("Insert the employee's name: ");
                string name = Console.ReadLine();

                Console.Write("Insert the employee's id: ");
                int id = int.Parse(Console.ReadLine());

                Employee duplicatedId = employees.Find(x => x.Id == id);
                if (duplicatedId == null) {
                    Console.Write("Insert the employee's salary: ");
                    double salary = double.Parse(Console.ReadLine());

                    Employee employee = new Employee(id, name, salary);
                    employees.Add(employee);

                    Console.WriteLine("\nUser was cadastred with sucessful!\n");
                }
                else {
                    Console.WriteLine("\nThis ID is in use! Please try with another ID.\n");
                }
            }

            ListEmployees(employees);

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSalaryIncrease = int.Parse(Console.ReadLine());

            Employee employeeSalaryIncrease = employees.Find(x => x.Id == idSalaryIncrease);
            if(employeeSalaryIncrease != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());

                employeeSalaryIncrease.increaseSalary(percentage);
            } else {
                Console.WriteLine("\nId not found.\n");
            }
            ListEmployees(employees);
        }
    }
}
