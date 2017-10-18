using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PaymentGatewayFactory();
            var product = new Product
            {
                Description = "Sample description",
                Name = "Gas",
                Price = 50
            };

            var gateway = factory.CreatePaymenyGateway(EPaymentMethod.BankOne, product);

            gateway.PerformPayment(product);
            Console.ReadLine();
        }
    }
}