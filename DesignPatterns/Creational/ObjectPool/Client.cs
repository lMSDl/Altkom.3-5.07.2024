namespace Altkom._3_5._07._2024.DesignPatterns.Creational.ObjectPool
{
    internal class Client
    {
        public static void Execute()
        {
            /*var counter = 0;
            while (true)
            {
                if (counter > 1000)
                {
                    Thread.Sleep(1);
                    continue;
                }
                var item = new Item() { IsVisible = true };
                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; Interlocked.Decrement(ref counter); });
                Interlocked.Increment(ref counter);
            }*/

            /*var objectPool = new ObjectPool<Item>(1000, () => new Item());
            while (true)
            {
                var item = objectPool.Acquire();
                if (item is null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; objectPool.Release(item); });
            }*/

            var itemPool = new ItemPool(1000);
            while (true)
            {
                var item = itemPool.Acquire();
                if (item is null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; });
            }
        }
    }
}
