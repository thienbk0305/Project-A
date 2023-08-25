using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Vemaybay
    {
        public string TenChuyen { get; set; }
        public string NgayBay { get; set; }
        public decimal GiaVe { get; set; }
        public void Enter()
        {
            Console.Write("Nhập Tên Chuyến Bay: ");
            TenChuyen = Console.ReadLine();
            Console.Write("Nhập Ngày Bay: ");
            NgayBay = Console.ReadLine();
            Console.Write("Nhập giá vé: ");
            GiaVe = decimal.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Tên chuyến bay: {TenChuyen}");
            Console.WriteLine($"Ngày Bay: {NgayBay}");
            Console.WriteLine($"Giá Vé: {GiaVe:C}");
        }

        public decimal GetGiaVe()
        {
            return GiaVe;
        }

    }
}
