using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.Prototype
{
    internal class Client
    {
        public static void Execute()
        {
            var p0 = new Person()
            {
                FirstName = "Ewa",
                LastName = "Ewowska",
                Age = 45,
                Address = new Address { City = "Warszawa", Street = "Krakowska" },
                Parent = new Person() { FirstName = "Tadeusz", LastName = "Ewowski" }
            };

            p0.Parent.Children.Add(p0);

            Console.WriteLine(p0);

            var p1 = (Person)p0.Clone();

            p1.FirstName = "Monika";

            p1.Parent.Children.Add(p1);

            Console.WriteLine(p1);

            p0.Address.Street = "Poznańska";

            p1.Parent.FirstName = "Tadek";

            Console.WriteLine(p0);
            Console.WriteLine(p1);

        }
    }
}
