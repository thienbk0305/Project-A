using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    interface IProductManager
    {
        void ProductInsert(Product product);
        void ProductUpdate(int id, Product updatedProduct);
        void ProductDelete(int id);
        void ShowProductList();
        Product GetProductById(int idToUpdate);
        void SaveToFile(string fileName);
    }
    class ProductManager : IProductManager
    {
        private List<Product> productList = new List<Product>();

        public Product GetProductById(int id)
        {
            return productList.FirstOrDefault(p => p.Id == id);
        }
        public void ProductInsert(Product product)
        {
            productList.Add(product);
        }
        public void ProductUpdate(int id, Product updatedProduct)
        {
            int index = productList.FindIndex(p => p.Id == id);
            if (index != -1)
            {
                productList[index] = updatedProduct;
            }
        }
        public void ProductDelete(int id)
        {
            productList.RemoveAll(p => p.Id == id);
        }
        public void ShowProductList()
        {
            foreach (Product product in productList)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price:C}, Quantity: {product.Quantity}");
            }
        }
        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Product product in productList)
                {
                    writer.WriteLine($"{product.Id},{product.Name},{product.Price},{product.Quantity}");
                }
            }
        }

    }
}
