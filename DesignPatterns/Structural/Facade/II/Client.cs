using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        public static void Execute()
        {

            int[] productIds = new[] { 2, 63, 21, 7 };


            /*ICartService cartService = null;
            IProductService productService = null;
            IPaymentService paymentService = null;

            foreach (var productId in productIds)
            {
                var price = productService.GetPrice(productId);
                cartService.AddProduct(productId, price);
            }
            paymentService.Pay(cartService.GetId(), cartService.GetValue());*/

            var shop = new Facade();
            shop.Buy(productIds);
        }
    }
}
