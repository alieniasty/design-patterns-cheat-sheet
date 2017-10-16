namespace FluentBuilder.Structural
{
    public class FluentProductBuilderStructural
    {
        private string _barCode;
        private string _brandName;
        private double _price;

        public FluentProductBuilderStructural WithBarCode(string barCode)
        {
            _barCode = barCode;
            return this;
        }

        public FluentProductBuilderStructural WithBrand(string brandName)
        {
            _brandName = brandName;
            return this;
        }

        public FluentProductBuilderStructural WithPrice(double price)
        {
            _price = price;
            return this;
        }

        public Product Build()
        {
            return new Product(_barCode, _brandName, _price);
        }

    }
}
