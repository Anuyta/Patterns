using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaabcadda  d";
            var adapt = new CountLetterAdapter(str);
            char lett1 = 'd';
            char lett2 = 'a';
            var count1 = adapt.CountLetter(lett1);
            var count2 = adapt.CountLetter(lett2);
            Console.WriteLine("string - {0}", str);
            Console.WriteLine("letter - {0} - count = {1}", lett1, count1);
            Console.WriteLine("letter - {0} - count = {1}", lett2, count2);
            Console.ReadLine();
        }
    }
}
