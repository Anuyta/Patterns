namespace Decoracor
{
    interface IProduct
    {
        decimal Price { get; set; }

        string Name { get; set; }

        string VendorCode { get; set; }

        string GetProductInfo();
    }
}
