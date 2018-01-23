namespace Decoracor
{
    class Product : IProduct
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string VendorCode { get; set; }

        public string GetProductInfo()
        {
            return string.Format("{0} - {1}, Price = {2}", VendorCode, Name, Price);
        }
    }
}
