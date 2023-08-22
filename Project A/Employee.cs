using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
