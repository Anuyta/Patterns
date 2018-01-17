using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new TaxFreeBuilder(10);

            var taxFree = builder.BuildSurname("Ivanov")
                .BuildName("Ivan")
                .BuildCountry("Poland")
                .BuildCity("Krakov")
                .BuildDate(new DateTime(2017, 2, 28))
                .BuildPrice(200).GetTaxFreeForm();

            Console.WriteLine(taxFree);
            Console.ReadLine();
        }
    }
}
