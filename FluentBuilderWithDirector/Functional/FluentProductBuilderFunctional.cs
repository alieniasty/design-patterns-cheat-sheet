using System;

namespace FluentBuilder.Functional
{
    public class FluentProductBuilderFunctional
    {
        private Func<Product, Product> ConstructFunction;

        public FluentProductBuilderFunctional Begin()
        {
            ConstructFunction = ignored => new Product();
            return this;
        }

        public FluentProductBuilderFunctional WithBarCode(string barCode)
        {
            ConstructFunction = FuncUtils.Compose(ConstructFunction, product =>
            {
                product.BarCode = barCode;
                return product;
            });


            return this;
        }

        public FluentProductBuilderFunctional WithBrand(string brand)
        {
            ConstructFunction = FuncUtils.Compose(ConstructFunction, product =>
            {
                product.Brand = brand;
                return product;
            });

            return this;
        }

        public FluentProductBuilderFunctional WithPrice(double price)
        {
            ConstructFunction = FuncUtils.Compose(ConstructFunction, product =>
            {
                product.Price = price;
                return product;
            });

            return this;
        }

        public Product Build()
        {
            return ConstructFunction(null);
        }


    }
}
