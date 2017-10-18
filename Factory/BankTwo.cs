using System;

namespace Factory
{
    public class BankTwo : IPaymentGateway
    {
        public void PerformPayment(Product product)
        {
            Console.WriteLine($"Payment method from second bank. Product: {product.Name}, price: {product.Price}");
        }
    }
}
