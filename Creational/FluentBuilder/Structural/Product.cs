namespace FluentBuilder.Structural
{
    public class Product
    {
        public string BarCode { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }

        public Product(string barCode, string brand, double price)
        {
            BarCode = barCode;
            Brand = brand;
            Price = price;
        }
    }
}
