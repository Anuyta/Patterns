using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SimpleOperations
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mult(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            if (y == 0)
                throw new ArgumentException("Diveded by 0");
            return x / y;
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
