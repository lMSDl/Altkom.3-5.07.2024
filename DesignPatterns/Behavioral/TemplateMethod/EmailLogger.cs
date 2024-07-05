using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger
    {
        public void Log(object message)
        {
            var messageToLog = SerializeMessage(message);
            SendLogToEmail(messageToLog);
        }
        private string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
        private void SendLogToEmail(string message)
        {
            Console.WriteLine("Sending Email with Log Message : " + message);
        }
    }
}
