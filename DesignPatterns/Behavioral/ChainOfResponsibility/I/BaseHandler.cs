using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class BaseHandler : IDiscountHandler
    {
        private readonly IDiscountHandler? _next;
        public BaseHandler(IDiscountHandler? next)
        {
            _next = next;
        }

        public virtual bool Discount(float value, float price)
        {
            return _next?.Discount(value, price) ?? false;
        }
    }
}
