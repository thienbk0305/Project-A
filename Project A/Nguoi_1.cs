using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Nguoi_1
    {
        public string Ten { get; set; }
        public string SoTaiKhoan { get; set; }
        public decimal SoDu { get; set; }

        public virtual void Enter()
        {
            Console.Write("Nhap Ten: ");
            Ten = Console.ReadLine();

            Console.Write("Nhap So Tai Khoan: ");
            SoTaiKhoan = Console.ReadLine();

            Console.Write("Nhao So Du: ");
            SoDu = decimal.Parse(Console.ReadLine());

            if (SoDu < 0)
            {
                throw new Exception("Khong Du So Du");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Ten: {Ten}");
            Console.WriteLine($"So Tai Khoan: {SoTaiKhoan}");
            Console.WriteLine($"So Du: {SoDu:C}");
        }
    }
}
