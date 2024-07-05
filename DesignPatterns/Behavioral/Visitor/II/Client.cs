using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Visitor.II
{
    internal class Client
    {
        public static void Execute()
        {
            var products = new List<Product> { new Product(), new BoxedProduct() };
            foreach (var item in products)
            {
                item.PrintType();
            }
            Console.WriteLine();

            var baskets = new List<Basket> { new Basket(), new Cart() };
            foreach (var basket in baskets)
            {
                foreach (var product in products)
                {
                    //basket.Add(product);
                    product.Accept(basket);
                }
            }
        }
    }
}
