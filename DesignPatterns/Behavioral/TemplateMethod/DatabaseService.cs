using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DatabaseService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Insert(DbLog log)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + log.Message);
        }
    }
}
