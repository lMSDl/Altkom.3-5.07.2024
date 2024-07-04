using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            ICircle circle = new Circle() { R = 5 };
            CheckR(circle);

            circle = new SquareToCircleAdapter( new Square() { A = 7 });


            CheckR(circle);
        }

        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
}
}
