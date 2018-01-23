using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoracor
{
    class PolandProduct : ProductDecorator, IExchangeRate
    {
        public decimal ExchangeRate { get; set; }

        public PolandProduct(IProduct product, decimal exchRate) : base(product)
        {
            ExchangeRate = exchRate;
        }

        public override string GetProductInfo()
        {
            return base.GetProductInfo() + string.Format("{0} PLN", Decimal.Round(base.Price / ExchangeRate * 10, 2));
        }
    }
}
