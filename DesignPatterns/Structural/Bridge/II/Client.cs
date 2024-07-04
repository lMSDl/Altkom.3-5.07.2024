using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal class Client
    {
        public static void Execute()
        {
            Console.WriteLine("Send Email");
            MessageAbstraction message = new MessageAbstraction(new EmailGate());
            message.Send(Console.ReadLine());


            Console.WriteLine("Send SMS");
            message = new MessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());
        }
    }
}
