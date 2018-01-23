using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoracor
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod = new Product() { Name = "table", Price = 100, VendorCode = "#123" };

            var prod1 = new BelarusProduct(prod);
            Console.WriteLine("BelarusProduct");
            Console.WriteLine(prod1.GetProductInfo());

            var prod2 = new PolandProduct(prod, 5.75M);
            Console.WriteLine("PolandProduct");
            Console.WriteLine(prod2.GetProductInfo());

            var prod3 = new RussianProduct(prod, 3.505M);
            Console.WriteLine("RussianProduct");
            Console.WriteLine(prod3.GetProductInfo());

            Console.ReadLine();
        }
    }
}
