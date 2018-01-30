using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Observer : IObserver<IntegerNumberCollection>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(IntegerNumberCollection value)
        {
            Console.WriteLine("I got sorted collection");
        }
    }
}
