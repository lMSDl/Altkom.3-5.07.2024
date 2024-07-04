using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class ProductFlyweight : ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public byte[] Logo { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShowShortInfo(Product context)
        {
            Console.WriteLine($"{Name} ({context.ExpirationDate.ToShortDateString()})");
        }
    }
}
