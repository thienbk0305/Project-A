using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Employee_1
    {
        public string Id { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public decimal LuongCanBan { get; set; }
        public decimal HeSoLuong { get; set; } = 2.0M;
        public decimal PhuCap { get; set; }
        public decimal TongLuong => LuongCanBan * HeSoLuong + PhuCap;
    }
    interface IEmployeeManager_1
    {
        Employee_1 GetEmployeeById(string id);
        void AddEmployee(Employee_1 employee);
        void UpdateEmployee(string id, Employee_1 updatedEmployee);
        void DeleteEmployee(string id);
        string GenerateRandomId();
        void ShowEmployeeList();
        List<Employee_1> SearchEmployeesByName(string name);
    }
    class EmployeeManager_1 : IEmployeeManager_1
    {
        private List<Employee_1> employees = new List<Employee_1>();

        public Employee_1 GetEmployeeById(string id)
        {
            return employees.FirstOrDefault(p => p.Id == id);
        }
        public void AddEmployee(Employee_1 employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(string id, Employee_1 updatedEmployee)
        {
            int index = employees.FindIndex(e => e.Id == id);
            if (index != -1)
            {
                employees[index] = updatedEmployee;
            }
        }
        public void DeleteEmployee(string id)
        {
            employees.RemoveAll(e => e.Id == id);
        }

        public List<Employee_1> SearchEmployeesByName(string name)
        {
            return employees.FindAll(e => e.Ten.ToLower().Contains(name.ToLower()));
        }
        public string GenerateRandomId()
        {
            return Guid.NewGuid().ToString("N");
        }

        public void ShowEmployeeList()
        {
            foreach (Employee_1 emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Tên: {emp.Ten}, GioiTinh: {emp.GioiTinh}, Tuổi: {emp.Tuoi}, Lương Căn Bản: {emp.LuongCanBan:C}, Phụ Cấp: {emp.PhuCap:C}, Tổng Lương: {emp.TongLuong:C}");
            }
        }
    }
}
