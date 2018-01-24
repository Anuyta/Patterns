using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class OtherClass : IObserver<ClassA>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(ClassA a)
        {
            using (StreamWriter sw = new StreamWriter("value.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(String.Format("value = {0}, time - {1}", a.Value, DateTime.Now));
            }
        }
    }
}
