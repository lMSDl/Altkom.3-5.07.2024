using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6" };

            var buffer = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(buffer + list[i]);
                buffer = list[i];
            }

            Console.WriteLine("---");

            var iterator = list.GetEnumerator();
            if (iterator.MoveNext())
            {
                buffer = iterator.Current;
                while (iterator.MoveNext())
                {
                    Console.WriteLine(buffer + iterator.Current);
                    buffer = iterator.Current;
                }
            }

            Console.WriteLine("---");

            var bufferIterator = new Buffer<string>(list).GetEnumerator();
            while (bufferIterator.MoveNext())
            {
                Console.WriteLine(bufferIterator.Current.Item1 + bufferIterator.Current.Item2);
            }

            Console.WriteLine("---");

            foreach (var item in new Buffer<string>(list))
            {
                Console.WriteLine(item.Item1 + item.Item2);
            }

            Console.WriteLine("---");

            foreach (var item in list.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count == 2)
                .ToEnumerable())
                Console.WriteLine(item[0] + item[1]);

        }
    }
}
