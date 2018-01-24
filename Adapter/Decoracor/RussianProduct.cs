using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoracor
{
    class RussianProduct : ProductDecorator, IExchangeRate
    {
        public decimal ExchangeRate { get; set; }

        public RussianProduct(IProduct product, decimal exchRate) : base(product)
        {
            ExchangeRate = exchRate;
        }

        public override string GetProductInfo()
        {
            return base.GetProductInfo() + string.Format("{0} RUB", Decimal.Round(base.Price / ExchangeRate * 100, 2));
        }
    }
}
