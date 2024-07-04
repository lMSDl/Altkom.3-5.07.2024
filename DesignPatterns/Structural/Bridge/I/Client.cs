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
            Blue blue = new Blue();
            shape.Color = blue;

            Console.WriteLine(shape);

            Shape circle = new Circle();
            Red red = new Red();
            circle.Color = red;
            Dark dark = new Dark();
            red.Brightness = dark;

            Console.WriteLine(circle);
        }
    }
}
