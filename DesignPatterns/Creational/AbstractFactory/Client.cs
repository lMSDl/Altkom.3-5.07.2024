using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.AbstractFactory
{
    internal class Client
    {
        public static void Execute()
        {
            Order order;

            order = new Order("Honda", nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order("Toyota", nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order("Toyota", nameof(ISuv), "full");
            Console.WriteLine(order.ManufacturedCarName());

        }
    }
}
