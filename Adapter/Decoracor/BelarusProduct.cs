using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoracor
{
    class BelarusProduct : ProductDecorator
    {
        public BelarusProduct(IProduct product) : base(product)
        {
        }

        public override string GetProductInfo()
        {
            return base.GetProductInfo() + string.Format("{0} BYN", Decimal.Round(base.Price, 2));
        }
    }
}
