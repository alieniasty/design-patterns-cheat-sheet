using FluentBuilder.Functional;
using FluentBuilder.Structural;
using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new FluentProductBuilderStructural();

            var product = builder.WithBarCode("235434")
                .WithBrand("Nestle")
                .WithPrice(1.55)
                .Build();

            var functionalBuilder = new FluentProductBuilderFunctional();

            var functionalProduct = functionalBuilder.WithBarCode("345345")
                .Begin()
                .WithBrand("Nescafe")
                .WithPrice(1.9)
                .Build();

            Console.WriteLine(product.Brand);
            Console.WriteLine(functionalProduct.Brand);

            Console.ReadLine();
        }
    }
}