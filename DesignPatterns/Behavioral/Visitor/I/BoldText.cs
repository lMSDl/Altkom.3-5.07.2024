using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal class BoldText : IElement
    {
        public string Text { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
