using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaabcadda  d";
            var adapt = new ProxyStringAdapter(str);
            char lett1 = 'd';
            adapt.CountLetter(lett1);
            Console.WriteLine(adapt.GetString);
            Console.ReadLine();
        }
    }
}
