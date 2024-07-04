using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Proxy
{
    internal class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();
            //database = new DatabaseCacheProxy(database);
            database = new DatabaseProxy((Database)database);


            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(250);
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();
        }
    }
}
