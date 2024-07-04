using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public string Manufacturer { get; set; }
        public byte[] Logo { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public void ShowShortInfo()
        {
            Console.WriteLine($"{Name} ({ExpirationDate.ToShortDateString()})");
        }
    }
}
