using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleOperations simpOper = new SimpleOperations();
            OtherOperations othOper = new OtherOperations();

            MathFacade facade = new MathFacade(simpOper, othOper);

            Console.WriteLine("Diveded 10 / 2.5 = {0}", facade.Div(10, 2.5));

            Console.WriteLine("Factorial 6 = {0}", facade.Factorial(6));

            Console.WriteLine("Log: number - 5 base - 3 = {0}", facade.Log(5, 3));

            Console.ReadLine();
        }
    }
}
