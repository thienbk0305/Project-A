using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Good
    {
        public int Code { get; set; }
        public string GoodName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public void PrintGoodInfo()
        {
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"Good Name: {GoodName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Unit Price: {UnitPrice:C}");
        }
    }
}
