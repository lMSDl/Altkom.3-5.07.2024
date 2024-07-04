using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Decorator
{
    internal class SmsNotification : BaseDecorator
    {
        public const int MaxLengh = 16;

        public SmsNotification(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            foreach (var item in Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLengh))
                                           .Select(x => message.Substring(x * MaxLengh, Math.Min(MaxLengh, message.Length - x * MaxLengh))))
            {
                Console.WriteLine($"SMS: {item}");
            }
        }
    }
}
