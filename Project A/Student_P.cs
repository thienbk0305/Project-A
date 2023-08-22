using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Student_P : Person
    {
        public int Age { get; set; }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Age: {Age}");
        }
    }
}
