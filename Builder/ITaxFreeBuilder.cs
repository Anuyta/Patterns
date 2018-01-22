using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface ITaxFreeBuilder
    {
        ITaxFreeBuilder BuildSurname(string surname);

        ITaxFreeBuilder BuildName(string name);

        ITaxFreeBuilder BuildCountry(string country);

        ITaxFreeBuilder BuildCity(string city);

        ITaxFreeBuilder BuildPassportId(string passportId);

        ITaxFreeBuilder BuildDate(DateTime dayOfPurchase);

        ITaxFreeBuilder BuildPrice(decimal price);

        string GetTaxFreeForm();

    }
}
