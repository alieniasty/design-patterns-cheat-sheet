namespace Factory
{
    public interface IPaymentGateway
    {
        void PerformPayment(Product product);
    }
}
