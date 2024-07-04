using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class Client
    {
        public static void Execute()
        {
            var product1 = new Product
            {
                Name = "N1",
                Description = "D1",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Logo = new byte[1024],
                Weight = 100,
                Manufacturer = "M1"
            };

            var product2 = new Product
            {
                Name = "N2",
                Description = "D2",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Logo = new byte[1024],
                Weight = 100,
                Manufacturer = "M1"
            };

            Show(product1);
            Show(product2);

            product1.ShowShortInfo();
        }

        public static void Show(Product product)
        {
            Console.WriteLine($"{product.Name}; {product.Description}; {product.Manufacturer}; {product.ProductionDate.ToShortDateString()}; {product.ExpirationDate.ToShortDateString()}");
        }
    }
}
