using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class StudentFactory : IFactory
    {
        private double averageMark;
        private bool isForeignLanguage;

        public StudentFactory(double averageMark, bool isForeignLanguage)
        {
            this.averageMark = averageMark;
            this.isForeignLanguage = isForeignLanguage;
        }

        public IStudent CreateStudent()
        {
            if (isForeignLanguage == true)
                return new ForeignStudent();
            if (averageMark <= 10.0 && averageMark >= 9.0)
                return new ExcellentStudent();
            if (averageMark < 9.0 && averageMark >= 6.0)
                return new GoodStudent();
            if (averageMark < 6.0 && averageMark >= 2.0)
                return new BadStudent();

            throw new ArgumentException("Invalid param");
        }
    }
}
