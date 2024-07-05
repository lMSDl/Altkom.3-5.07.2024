using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Strategy
{
    internal class Client
    {
        public static void Execute()
        {
            var calculator = new Calculator();

            while (true)
            {
                var line = Console.ReadLine();
                var split = line.Split(' '); // 2 + 4
                if (split.Length < 3)
                    continue;

                calculator.CalcStrategy = GetStrategy(split[1]);

                if (float.TryParse(split[0], out var a) && float.TryParse(split[2], out var b))
                {
                    Console.WriteLine(calculator.Operate(a, b));
                    Console.WriteLine(GetFunc(split[1])(a, b));
                }
            }
        }

        private static ICalcStrategy? GetStrategy(string sign)
        {
            switch(sign)
            {
                case "+":
                    return new PlusStrategy();
                case "-":
                    return new MinusStrategy();
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
            }
            return null;
        }

        static Func<float, float, float> GetFunc(string sign)
        {
            switch (sign)
            {
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
            }
            return null;
        }

    }
}
