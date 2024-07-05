using Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.NullObject
{
    internal class Client
    {
        public static void Execute()
        {
            var objects = new AbstractObject[] { new RealObject(), new NullObject() };
            var random = new Random();

            while (true)
            {
                var value = random.Next(0, objects.Length);
                Console.ReadLine();

                var item = objects[value];

                item.Method1();
                item.Method2();
                item.Method3();
            }
        }
    }
}
