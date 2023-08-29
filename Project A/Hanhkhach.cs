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

        public void Enter_HK()
        {
            base.Enter();

            Console.Write("Nhập Số Lượng Vé: ");
            SoLuong = int.Parse(Console.ReadLine());

            Ve = new Vemaybay();
            Ve.Enter();
        }
        public void Print_HK()
            {
                Console.WriteLine("Thông Tin Hành Khách:");
                base.Print();
                Console.WriteLine($"Số lượng: {SoLuong}");
                Console.WriteLine("Thông Tin Vé Máy Bay:");
                Ve.Print();
            }

            public decimal TongTien()
            {
                return Ve.GetGiaVe() * SoLuong;
            }
    }
}
