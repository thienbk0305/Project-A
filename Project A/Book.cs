using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int YearOfPublication { get; set; }
        public string ISBN { get; set; }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year of Publication: {YearOfPublication}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
