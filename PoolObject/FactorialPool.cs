using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolObject
{
    public class FactorialPool
    {
        private readonly int minSize;
        private readonly int maxSize;
        private readonly IList<RandomNumber> numbers;

        public FactorialPool(int minSize, int maxSize)
        {
            this.minSize = minSize;
            this.maxSize = maxSize;
            numbers = new List<RandomNumber>();
            for (int i = 0; i < minSize; i++)
            {
                numbers.Add(new RandomNumber());
            }            
        }

        private RandomNumber CreateObject()
        {
            if(numbers.Count < maxSize)
            {
                var factObject = new RandomNumber();
                numbers.Add(factObject);
                return factObject;
            }
            return null;
        }

        public RandomNumber GetRandomNumber()
        {
            var number = numbers.FirstOrDefault(n => !n.IsInUse) ?? CreateObject();
            number.IsInUse = true;
            return number;
        }

        public void ReleaseNumber(RandomNumber number)
        {
            if (!numbers.Contains(number))
                throw new InvalidOperationException("random number does not belong the factorial pool");

            number.IsInUse = false;
        }
    }
}
