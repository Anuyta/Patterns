using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ClassA : IObservable<ClassA>
    {
        private int value;

        private readonly IList<IObserver<ClassA>> listeners = new List<IObserver<ClassA>>();
        
        public int Value
        {
            get { return value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    Notify();
                }
            }
        }

        public ClassA()
        {
            value = 0;
        }

        public IDisposable Subscribe(IObserver<ClassA> observer)
        {
            listeners.Add(observer);
            return new Unsubscriber(this, observer);
        }

        private void Notify()
        {
            foreach (var list in listeners)
            {
                list.OnNext(this);
            }
        }

        private class Unsubscriber : IDisposable
        {
            private readonly ClassA sensor;
            private readonly IObserver<ClassA> listener;

            public Unsubscriber(ClassA sensor, IObserver<ClassA> listener)
            {
                this.sensor = sensor;
                this.listener = listener;
            }

            public void Dispose()
            {
                sensor.listeners.Remove(listener);
            }
        }
    }
}
