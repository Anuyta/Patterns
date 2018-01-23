using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class MathFacade
    {
        SimpleOperations simpleOperations;
        OtherOperations otherOperations;

        public MathFacade(SimpleOperations simpleOperations, OtherOperations otherOperations)
        {
            this.simpleOperations = simpleOperations;
            this.otherOperations = otherOperations;
        }

        public double Sum(double x, double y)
        {
            return simpleOperations.Sum(x, y);
        }

        public double Sub(double x, double y)
        {
            return simpleOperations.Sub(x, y);
        }

        public double Mult(double x, double y)
        {
            return simpleOperations.Mult(x, y);
        }

        public double Div(double x, double y)
        {
            return simpleOperations.Div(x, y);
        }

        public double Sqrt(double x)
        {
            return simpleOperations.Sqrt(x);
        }

        public double Pow(double x, double y)
        {
            return simpleOperations.Pow(x, y);
        }

        public BigInteger Factorial(int x)
        {
            return otherOperations.Fact(x);
        }

        public double Log(double x, double y)
        {
            return otherOperations.Log(x, y);
        }
    }
}
