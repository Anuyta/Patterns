using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                IFactory factory = new StudentFactory(6.3, true);
                var student = factory.CreateStudent();
                Console.WriteLine(student.InfoAboutStudent);

                IFactory factory1 = new StudentFactory(4, false);
                var student2 = factory1.CreateStudent();
                Console.WriteLine(student2.InfoAboutStudent);

                IFactory factory2 = new StudentFactory(9, false);
                var student3 = factory2.CreateStudent();
                Console.WriteLine(student3.InfoAboutStudent);

                IFactory factory3 = new StudentFactory(0, false);
                var student4 = factory3.CreateStudent();
                Console.WriteLine(student4.InfoAboutStudent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
