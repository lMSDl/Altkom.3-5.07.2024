using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger : Logger<string, IDisposable>
    {

        protected override void Save(string item, IDisposable _)
        {
            Console.WriteLine("Sending Email with Log Message : " + item);
        }

        protected override string CreateItem(string message)
        {
            return message;
        }

        protected override IDisposable GetService()
        {
            return null;
        }
    }
}
