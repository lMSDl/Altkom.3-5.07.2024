
using System.Collections;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Iterator
{
    internal class BufferIterator<T> : IEnumerator<(T, T)>
    {
        private IEnumerator<T> enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            this.enumerator = enumerator;
            Reset();
        }

        public (T, T) Current { get; set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            enumerator.Dispose();
            enumerator = null;
            Current = default;
        }

        public bool MoveNext()
        {
            if(enumerator.MoveNext())
            {
                Current = (Current.Item2, enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            enumerator.Reset();
            Current = enumerator.MoveNext() ? ((T, T))(default, enumerator.Current) : default;
        }
    }
}