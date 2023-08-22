using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_A
{
    public class Teacher: Person
    {
        public string Job { get; set; }

        public void SetJob(string job)
        {
            Job = job;
        }

        public void ShowTeacherInfo()
        {
            Console.WriteLine($"Teacher Name: {Name}");
            Console.WriteLine($"Teacher Job: {Job}");
        }
    }
}
