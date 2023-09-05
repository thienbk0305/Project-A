using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class KhachHang : Nguoi_1
    {
        public List<GiaoDich> GiaoDich { get; set; } = new List<GiaoDich>();
        //Console.OutputEncoding = Encoding.UTF8;
        public override void Enter()
        {
            base.Enter();

            Console.Write("Nhập Số Lượng Giao Dịch: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Thông Tin Giao Dịch Lần {i + 1}:");
                GiaoDich giaoDich = new GiaoDich();
                giaoDich.Enter();
                GiaoDich.Add(giaoDich);
            }
        }

        public new void Print()
        {
            base.Print();

            Console.WriteLine("Danh Sách Giao Dịch:");
            foreach (GiaoDich giaoDich in GiaoDich)
            {
                giaoDich.Print();
                Console.WriteLine();
            }

            Console.WriteLine($"Tổng Tiền: {TongTien():C}");
        }

        public decimal TongTien()
        {
            decimal total = 0;
            foreach (GiaoDich giaoDich in GiaoDich)
            {
                total += giaoDich.GetGiaTri();
            }
            return total;
        }
    }
}
