using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Proxy
{
    internal class Database : IDatabase
    {
        public const int MAX_CONNECTIONS = 5;
        public int _connectionCounter = 0;
        public bool IsConnected { get; private set; }

        public Database()
        {
            Connect();
        }

        public void Connect()
        {
            Console.WriteLine("Otwieranie połącznia z bazą danych...");
            IsConnected = true;
        }

        public async Task RequestAsync(int @int)
        {
            if (_connectionCounter >= MAX_CONNECTIONS)
            {
                Console.WriteLine($"Zapytanie {@int} odrzucone!");
                return;
            }

            Interlocked.Increment(ref _connectionCounter);

            await Task.Delay(new Random(@int).Next(1000, 2500));
            Console.WriteLine($"Zakończono zapytanie {@int}");

            Interlocked.Decrement(ref _connectionCounter);
        }
        public void Dispose()
        {
            Console.WriteLine("Zamykanie połącznia z bazą danych...");
            IsConnected = false;
        }
    }
}
