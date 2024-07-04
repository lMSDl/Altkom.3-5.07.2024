using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.I
{
    internal class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            Console.WriteLine(shape);

            Shape circle = new Circle();
            Console.WriteLine(circle);
        }
    }
}
