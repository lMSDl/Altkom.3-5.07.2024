using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Decorator
{
    internal class EmailNotification : BaseDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
