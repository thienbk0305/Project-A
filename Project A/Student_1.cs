using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Student_1
    {
        public int Number { get; set; }
        public string FullName { get; set; }
        public string StudentID { get; set; }
        public double ComponentScore { get; set; }
        public double ExamScore { get; set; }
        public double EndScore { get; set; }

        public bool RetakeScore()
        {
            return ExamScore < 5;
        }
        public void PrintStudentInfo()
        {
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Component Score: {ComponentScore}");
            Console.WriteLine($"Exam Score: {ExamScore}");
            Console.WriteLine($"End Score: {EndScore}");
        }
    }
}
