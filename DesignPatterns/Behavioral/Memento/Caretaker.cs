using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Memento
{
    internal class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        protected ICollection<Memento<T>> _mementos = new List<Memento<T>>();
        protected T originator;

        public Caretaker(T originator)
        {
            this.originator = originator;
        }

        public void SaveState()
        {
            var memento = new Memento<T>(originator);
            _mementos.Add(memento);
            Console.WriteLine($"Caretaker: snapshot {memento.DateTime}");
        }

        public void RestoreState()
        {
            var memento = GetLastMemento();
            if (memento != null)
            {
                _mementos.Remove(memento);
                RestoreState(memento);
            }
        }

        protected virtual Memento<T>? GetLastMemento()
        {
            return _mementos.LastOrDefault();
        }

        public void RestoreState(DateTime dateTime)
        {
            var memento = _mementos.LastOrDefault(x => x.DateTime <= dateTime);
            if (memento != null)
            {
                RestoreState(memento);
            }
        }

        protected virtual void RestoreState(Memento<T> memento)
        {
            originator.Restore(memento.GetState());
            Console.WriteLine($"Caretaker: restored {memento.DateTime}");
        }
    }
}
