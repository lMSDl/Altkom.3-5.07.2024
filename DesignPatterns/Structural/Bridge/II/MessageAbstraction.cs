using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal class MessageAbstraction
    {
        protected IMessageImplementation MessageSender { get; }
        public MessageAbstraction(IMessageImplementation messageSender)
        {
            MessageSender = messageSender;
        }


        public virtual void Send(string message)
        {
            message = MessageSender.PrepareMessage(message);
            MessageSender.SendMessage(message);
        }
    }
}
