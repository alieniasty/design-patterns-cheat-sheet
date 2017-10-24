using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ProductRepository();

            var product = repository.GetProductById(4);

            product.RateProduct(5);

            Console.ReadLine();
        }
    }
}
