using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class IntegerNumberCollection : IObservable<IntegerNumberCollection>, IEnumerable<int>
    {
        private List<int> numbers = new List<int>();
        private readonly IList<IObserver<IntegerNumberCollection>> listeners = 
                        new List<IObserver<IntegerNumberCollection>>();
       
        public IDisposable Subscribe(IObserver<IntegerNumberCollection> observer)
        {
            listeners.Add(observer);
            return new Unsubscriber(this, observer);
        }

        public void AddToCollection(int numb)
        {
            numbers.Add(numb);
            numbers.Sort();
            Notify();
        }

        public void RemoveFromCollection(int index)
        {
            numbers.RemoveAt(index);
            numbers.Sort();
            Notify();
        }
        
        private class Unsubscriber : IDisposable
        {
            private readonly IntegerNumberCollection sensor;
            private readonly IObserver<IntegerNumberCollection> listener;

            public Unsubscriber(IntegerNumberCollection sensor, IObserver<IntegerNumberCollection> listener)
            {
                this.sensor = sensor;
                this.listener = listener;
            }

            public void Dispose()
            {
                sensor.listeners.Remove(listener);
            }
        }

        private void Notify()
        {
            foreach (var list in listeners)
            {
                list.OnNext(this);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in numbers)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
