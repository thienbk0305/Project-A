using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public void Import()
        {
            Console.Write("Nhập Họ Tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập Giới Tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        public void Export()
        {
            Console.WriteLine($"Họ Tên: {HoTen}");
            Console.WriteLine($"Giới Tính: {GioiTinh}");
            Console.WriteLine($"Tuổi: {Tuoi}");
        }
        
    }
}
