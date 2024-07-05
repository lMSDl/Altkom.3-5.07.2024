using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Strategy
{
    internal class Calculator
    {
        public ICalcStrategy? CalcStrategy { get; set; }

        public float? Operate(float a, float b)
        {
            return CalcStrategy?.Calc(a, b);
        }
    }
}
