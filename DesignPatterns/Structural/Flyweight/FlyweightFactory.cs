using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class FlyweightFactory<T>
    {
        static FlyweightFactory() { }
        public static FlyweightFactory<T> Instance { get; } = new FlyweightFactory<T>();

        private FlyweightFactory() { }


        private Dictionary<string, T> _flyweights = new Dictionary<string, T>();


        private string GetKey(T productFlyweight)
        {
            return string.Join("_", typeof(T).GetProperties().Where(x => x.CanRead && x.CanWrite)
                         .OrderBy(x => x.Name).Select(x => x.GetValue(productFlyweight)));
        }

        public void Initialize(params T[] products)
        {
            foreach (var item in products)
            {
                _flyweights[GetKey(item)] = item;
            }
        }

        public T GetFlyweight(T productFlyweight)
        {
            var key = GetKey(productFlyweight);

            if (_flyweights.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine($"Pobieramy stan ze słownika {key}");
                return flyweight;
            }

            Console.WriteLine($"Dodajemy stan do słownika: {key}");
            _flyweights[key] = productFlyweight;
            return productFlyweight;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Fabryka posiada {_flyweights.Count} stanów:");

            foreach (var item in _flyweights)
            {
                stringBuilder.AppendLine(item.Key);
            }

            return stringBuilder.ToString();
        }
    }
}
