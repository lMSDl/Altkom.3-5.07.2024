using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal class SmsGate : IMessageImplementation
    {
        public const int MaxLength = 10;

        public string PrepareMessage(string message)
        {
            return string.Join("\n", Enumerable.Range(0, message.Length / MaxLength)
            .Select(i => message.Substring(i * MaxLength, MaxLength)));
        }

        public void SendMessage(string message)
        {
            foreach (var m in message.Split("\n"))
            {
                Console.WriteLine($"Wiadomość została wysłana przez bramkę SMS: {m}");
            }
        }
    }
}
