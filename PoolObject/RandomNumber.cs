using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PoolObject
{
    public class RandomNumber
    {
        private Random rnd;
        private BigInteger number;
        private BigInteger factOfNumber;

        public BigInteger FactOfNumber
        {
            get { return factOfNumber; }
        }

        public bool IsInUse { get; set; }

        public RandomNumber()
        {
            rnd = new Random();
            number = rnd.Next(100, 10000);
            factOfNumber = Factorial(number);
        }
        
        private static BigInteger Factorial(BigInteger n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }
    }
}
