using System;

namespace Factory
{
    public class BankOne : IPaymentGateway
    {
        public void PerformPayment(Product product)
        {
            Console.WriteLine($"Payment method from first bank. Product: {product.Name}, price: {product.Price}");
        }
    }
}
