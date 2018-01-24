using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class OtherOperations
    {
        public BigInteger Fact(int x)
        {
            BigInteger result;
            if (x == 1)
                return 1;
            result = Fact(x - 1) * x;

            return result;
        }

        public double Log(double x, double y)
        {
            return Math.Log(x, y);
        }
    }
}
