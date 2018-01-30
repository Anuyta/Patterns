using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var collect = new IntegerNumberCollection();
            var observer = new Observer();
            collect.Subscribe(observer);

            collect.AddToCollection(8);
            collect.AddToCollection(15);
            collect.AddToCollection(3);
            collect.AddToCollection(7);

            collect.RemoveFromCollection(2);

            foreach (var item in collect)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
