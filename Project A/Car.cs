using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Car
    {
        public string VehicleName { get; set; }
        public string EngineNumber { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfManufacture { get; set; }
        public int Quantity { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Vehicle Name: {VehicleName}");
            Console.WriteLine($"Engine Number: {EngineNumber}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year of Manufacture: {YearOfManufacture}");
            Console.WriteLine($"Quantity: {Quantity}");
        }
    }
}
