using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolObject
{
    class Program
    {
        static void Main(string[] args)
        {
           // RandomNumber number = new RandomNumber();            

            //Console.WriteLine(number.GetNumber());
            try
            {                
                var pool = new FactorialPool(2, 4);
                Console.WriteLine("Get 1st number");
                var number1 = pool.GetRandomNumber();
                Console.WriteLine(number1.FactOfNumber);

                Console.WriteLine("Get 2st number");
                var number2 = pool.GetRandomNumber();
                Console.WriteLine(number2.FactOfNumber);

                Console.WriteLine("Get 3st number");
                var number3 = pool.GetRandomNumber();
                Console.WriteLine(number3.FactOfNumber);

                Console.WriteLine("Get 4st number");
                var number4 = pool.GetRandomNumber();
                Console.WriteLine(number4.FactOfNumber);

                Console.WriteLine("Clear 1st");
                pool.ReleaseNumber(number1);

                Console.WriteLine("Get 5st number");
                var number5 = pool.GetRandomNumber();
                Console.WriteLine(number5.FactOfNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
