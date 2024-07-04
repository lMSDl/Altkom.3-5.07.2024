namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class Client
    {
        static Client()
        {
            FlyweightFactory<ProductFlyweight>.Instance.Initialize(
                new ProductFlyweight
                {
                    Name = "N1",
                    Description = "D1",
                    Logo = new byte[1024],
                    Manufacturer = "M1"
                },
                new ProductFlyweight
                {
                    Name = "N2",
                    Description = "D2",
                    Logo = new byte[1024],
                    Manufacturer = "M2"
                });
        }



        public static void Execute()
        {
            Console.WriteLine(FlyweightFactory<ProductFlyweight>.Instance);

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

            //product1.ProductFlyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product1.ProductFlyweight);

            var product11 = new Product
            {
                Name = "N1",
                Description = "D1",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Logo = new byte[1024],
                Weight = 100,
                Manufacturer = "M1"
            };
            product11.ProductFlyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product11.ProductFlyweight);

            product11.Name = "M2";
            //product11.ProductFlyweight = new ProductFlyweight { Logo = product11.Logo, Description = product11.Description, Manufacturer = product11.Manufacturer, Name = "M2" };
            //product11.ProductFlyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product11.ProductFlyweight);

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
            //product2.ProductFlyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product2.ProductFlyweight);

            Console.WriteLine(FlyweightFactory<ProductFlyweight>.Instance);





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
