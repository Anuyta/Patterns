using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();

            var listnerOne = new OtherClass();
            a.Subscribe(listnerOne);

            var listenerTwo = new OtherClass();
            a.Subscribe(listenerTwo);

            var listenerThree = new OtherClass();
            a.Subscribe(listenerThree);

            TimerCallback tm = new TimerCallback(v => ((ClassA)v).Value++);
            Timer timer = new Timer(tm, a, 0, 5000);

            Console.WriteLine("every 5 sec I'm writting in file...");
            Console.Read();
        }
    }
}
