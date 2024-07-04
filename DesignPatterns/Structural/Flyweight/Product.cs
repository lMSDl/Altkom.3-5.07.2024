using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class Product
    {
        public string Name { get => ProductFlyweight.Name; set => SetValue(x => x.Name = value); }
        public string Description { get => ProductFlyweight.Description; set => SetValue(x => x.Description = value); }
        public int Weight { get; set; }
        public string Manufacturer { get => ProductFlyweight.Manufacturer; set => SetValue(x => x.Manufacturer = value); }
        public byte[] Logo { get => ProductFlyweight.Logo; set => SetValue(x => x.Logo = value); }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public ProductFlyweight ProductFlyweight { get; set; } = new ProductFlyweight();

        private void SetValue(Action<ProductFlyweight> action)
        {
            var clone = (ProductFlyweight)ProductFlyweight.Clone();
            action(clone);
            ProductFlyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(clone);
        }


        public void ShowShortInfo()
        {
            ProductFlyweight.ShowShortInfo(this);
        }
    }
}
