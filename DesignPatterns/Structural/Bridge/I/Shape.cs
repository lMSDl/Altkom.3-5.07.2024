using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.I
{
    internal abstract class Shape
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
