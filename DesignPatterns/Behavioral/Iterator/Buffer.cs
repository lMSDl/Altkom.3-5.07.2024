using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Iterator
{
    internal class Buffer<T>(ICollection<T> collection) : IEnumerable<(T, T)>
    {

        public IEnumerator<(T, T)> GetEnumerator()
        {
            return new BufferIterator<T>(collection.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
