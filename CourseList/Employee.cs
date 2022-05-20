using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CourseList {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int Id, string Name, double Salary) {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public void increaseSalary(double percentage) {
            Salary = Salary + ((percentage / 100) * Salary);
        }
        public override string ToString() {
            return $"\nId: {Id}\nName: {Name}\nSalary: R${Salary.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
