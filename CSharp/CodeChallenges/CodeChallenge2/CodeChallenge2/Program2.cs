
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSorting
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
    }

    internal class Program2
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Enter Product Price: ");
                double price = double.Parse(Console.ReadLine());

                products.Add(new Product(productId, productName, price));
            }

            var sortedProducts = products.OrderBy(p => p.Price).ToList();

            Console.WriteLine("\nSorted Products by Price:");

            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            }

            Console.ReadLine();
        }
    }
}
