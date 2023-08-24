using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Item
    {
        public int CommodityCode { get; set; }
        public string GoodName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal CalculatePayment()
        {
            return Quantity * UnitPrice;
        }

        public void PrintItemInfo()
        {
            Console.WriteLine($"Commodity Code: {CommodityCode}");
            Console.WriteLine($"Good Name: {GoodName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Unit Price: {UnitPrice:C}");
            Console.WriteLine($"Payment for Item: {CalculatePayment():C}");
        }

        public decimal CalculateTotalAmount()
        {
            List<Item> items = new List<Item>();
            decimal total = 0;
            foreach (Item item in items)
            {
                total += item.CalculatePayment();
            }
            return total;
        }
        public decimal ApplyDiscount(decimal totalAmount)
        {
            if (totalAmount >= 1000000)
            {
                return totalAmount * 0.7M; // 30% off for total >= 1 million
            }
            else if (totalAmount >= 500000)
            {
                return totalAmount * 0.9M; // 10% off for total >= 500 thousand
            }
            else
            {
                return totalAmount;
            }
        }

        public void PrintBill()
        {
            Console.WriteLine("Purchase Bill:");
            List<Item> items = new List<Item>();
            foreach (Item item in items)
            {
                item.PrintItemInfo();
                Console.WriteLine();
            }

            decimal totalAmount = CalculateTotalAmount();
            decimal discountedTotal = ApplyDiscount(totalAmount);

            Console.WriteLine($"Total Amount: {totalAmount:C}");
            Console.WriteLine($"Discounted Total: {discountedTotal:C}");
        }
    }
}
