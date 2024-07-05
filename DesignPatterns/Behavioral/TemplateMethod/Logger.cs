using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal abstract class Logger<T, TService> where TService : IDisposable
    {
        public void Log(string message)
        {
            message = PrepareMessage(message);
            using TService service = GetService();

            T item = CreateItem(message);

            Save(item, service);

            //CloseService(service);
        }

        protected virtual void CloseService(TService service)
        {
            service?.Dispose();
        }

        protected abstract void Save(T item, TService service);
        protected abstract T CreateItem(string message);
        protected abstract TService GetService();

        protected virtual string PrepareMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return $"{DateTime.Now}: {message}";
        }
    }
}
