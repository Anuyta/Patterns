using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TaxFreeBuilder : ITaxFreeBuilder
    {
        private string taxFree = string.Empty;
        private decimal percent;

        public TaxFreeBuilder(decimal percent)
        {
            this.percent = percent;
        }

        public ITaxFreeBuilder BuildSurname(string surname)
        {
            taxFree += surname + Environment.NewLine;
            return this;
        }

        public ITaxFreeBuilder BuildName(string name)
        {
            taxFree += name + Environment.NewLine;
            return this;
        }

        public ITaxFreeBuilder BuildCountry(string country)
        {
            taxFree += country + Environment.NewLine;
            return this;
        }

        public ITaxFreeBuilder BuildCity(string city)
        {
            taxFree += city + Environment.NewLine;
            return this;
        }

        public ITaxFreeBuilder BuildPassportId(string passportId)
        {
            taxFree += passportId + Environment.NewLine;
            return this;
        }

        public ITaxFreeBuilder BuildDate(DateTime dayOfPurchase)
        {
            taxFree += dayOfPurchase + Environment.NewLine;
            return this;
        }

        public ITaxFreeBuilder BuildPrice(decimal price)
        {
            taxFree += price + Environment.NewLine;
            taxFree += "Cashback " + (price * percent / 100) + Environment.NewLine;
            return this;
        }

        public string GetTaxFreeForm()
        {
            return taxFree;
        }
    }
}
