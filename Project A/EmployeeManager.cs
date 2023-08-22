using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_A
{
    public class EmployeeManager
    {

        private List<Employee> employees = new List<Employee>();
        public void AddEmployee(string name, int age, double salary)
        {
            employees.Add(new Employee(name, age, salary));
        }
        public void EditEmployee(int index, string name, int age, double salary)
        {
            if (index >= 0 && index < employees.Count)
            {
                employees[index].Name = name;
                employees[index].Age = age;
                employees[index].Salary = salary;
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        public void CancelEmployee(int index)
        {
            if (index >= 0 && index < employees.Count)
            {
                employees.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        public void ShowEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }

    }
}
