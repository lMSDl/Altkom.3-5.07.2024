using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal class EmailGate : IMessageImplementation
    {
        public string PrepareMessage(string message)
        {
            return message;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Wiadomość została wysłana przez Email: {message}");
        }
    }
}
