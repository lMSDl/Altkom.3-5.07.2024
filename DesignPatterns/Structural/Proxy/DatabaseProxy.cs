using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private Database _database;

        public DatabaseProxy(Database database)
        {
            _database = database;
        }


        public const int MAX = 4;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(MAX);
        public async Task RequestAsync(int @int)
        {
            await semaphoreSlim.WaitAsync();

            if(!_database.IsConnected)
                _database.Connect();

            await _database.RequestAsync(@int);

            semaphoreSlim.Release();

            if (semaphoreSlim.CurrentCount == MAX)
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            _database?.Dispose();
        }
    }
}
