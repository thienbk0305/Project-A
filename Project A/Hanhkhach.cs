using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Hanhkhach : Nguoi
    {
            public Vemaybay Ve { get; set; }
            public int SoLuong { get; set; }

            public void Export_HK()
            {
                Console.WriteLine("Thông Tin Hành Khách:");
                base.Export();
                Console.WriteLine($"Số lượng: {SoLuong}");
                Console.WriteLine("Ve May Bay Information:");
                Ve.Xuat();
            }

            public decimal TongTien()
            {
                return Ve.GetGiaVe() * SoLuong;
            }
    }
}
