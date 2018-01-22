using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = LoggerSingleton.GetInstance();

            log.AddToLog("123", "11111111");
            Console.WriteLine("message was add to log");


            log.AddToLog("D:\\DOCUMENTS\\test", "222");
            Console.WriteLine("message was add to log");            

            Console.ReadLine();
        }
    }
}
