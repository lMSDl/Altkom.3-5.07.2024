using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger
    {
        public void Log(object message)
        {
            var messageToLog = SerializeMessage(message);
            var service = OpenFile();
            WriteLogMessage(service, messageToLog);
            CloseFile(service);
        }
        private string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
        private FileService OpenFile()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
        private void WriteLogMessage(FileService service, string message)
        {
            service.Write(message);
        }
        private void CloseFile(FileService service)
        {
            service.Dispose();
        }
    }
}
