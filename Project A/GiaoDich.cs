using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class GiaoDich
    {
        public string TenGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public decimal GiaTriGiaoDich { get; set; }
        public decimal HanMuc { get; set; }

        public void Enter()
        {
            Console.Write("Enter Ten Giao Dich: ");
            TenGiaoDich = Console.ReadLine();

            Console.Write("Enter Ngay Giao Dich (yyyy-MM-dd): ");
            NgayGiaoDich = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Gia Tri Giao Dich: ");
            GiaTriGiaoDich = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Han Muc: ");
            HanMuc = decimal.Parse(Console.ReadLine());

            if (HanMuc > 1000000000)
            {
                throw new Exception("HanMuc Vuot Qua 1 Ty.");
            }

            if (GiaTriGiaoDich < 0)
            {
                throw new Exception("Gia Tri Giao Dich Bi Am.");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Ten Giao Dich: {TenGiaoDich}");
            Console.WriteLine($"Ngay Giao Dich: {NgayGiaoDich:yyyy-MM-dd}");
            Console.WriteLine($"Gia Tri Giao Dich: {GiaTriGiaoDich:C}");
            Console.WriteLine($"Han Muc: {HanMuc:C}");
        }

        public decimal GetGiaTri()
        {
            return GiaTriGiaoDich;
        }
    }
}
