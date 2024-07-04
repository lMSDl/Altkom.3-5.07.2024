namespace Altkom._3_5._07._2024.DesignPatterns.Creational.ObjectPool
{
    internal class Client
    {
        public static void Execute()
        {
            var counter = 0;
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
            }
        }
    }
}
