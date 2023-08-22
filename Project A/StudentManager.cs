using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public void EditStudent(Student student, int index)
        {
            students[index] = student;
        }
        public void ShowStudent()
        {
            foreach (Student student in students)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, Age: {2}, Address: {3}, GPA: {4}, MathScore: {5}", student.Id, student.Name, student.Age, student.Address, student.GPA, student.MathScore);
            }
        }

        public void SortByGPA()
        {
            students.Sort((s1, s2) => s1.GPA.CompareTo(s2.GPA));
        }

        public Student FindStudentWithHighestMathScore()
        {
            if (students.Count == 0)
            {
                return null; // No students in the list
            }

            Student highestMathStudent = students[0];

            foreach (Student student in students)
            {
                if (student.MathScore > highestMathStudent.MathScore)
                {
                    highestMathStudent = student;
                }
            }

            return highestMathStudent;
        }
        public List<Student> GetStudentsAboveAge(int age)
        {
            List<Student> studentsAboveAge = new List<Student>();

            foreach (Student student in students)
            {
                if (student.Age > age)
                {
                    studentsAboveAge.Add(student);
                }
            }

            return studentsAboveAge;
        }
        public List<Student> FindStudentsFirstName(string firstName)
        {
            List<Student> studentsFirstName = new List<Student>();

            foreach (Student student in students)
            {
                if(student.Name.Length<firstName.Length)
                {
                    return studentsFirstName;
                }
                else
                {
                    if (student.Name.Substring(0,firstName.Length) == firstName)
                    {
                        studentsFirstName.Add(student);
                    }
                }

            }

            return studentsFirstName;
        }
        public List<Student> FindAddressName(string addess)
        {
            List<Student> studentsFindAddressName = new List<Student>();

            foreach (Student student in students)
            {
                if (CountSubstringOccurrences(student.Address,addess)>0)
                {
                    studentsFindAddressName.Add(student);
                }
            }

            return studentsFindAddressName;
        }
        static int CountSubstringOccurrences(string initialString, string substring)
        {
            int occurrences = 0;
            int index = 0;

            while ((index = initialString.IndexOf(substring, index)) != -1)
            {
                occurrences++;
                index += substring.Length;
            }

            return occurrences;
        }
    }
}
