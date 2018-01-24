using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoracor
{
    class ProductDecorator : IProduct
    {
        private IProduct product;

        public decimal Price { get; set; }

        public string Name { get; set; }

        public string VendorCode { get; set; }

        public ProductDecorator(IProduct product)
        {
            this.product = product;
            Price = product.Price;
        }

        public virtual string GetProductInfo()
        {
            return string.Format("{0} - {1}, Price = ", product.VendorCode, product.Name);
        }
    }
}
