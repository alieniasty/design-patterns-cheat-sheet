namespace Factory
{
    public class PaymentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymenyGateway(EPaymentMethod method, Product product)
        {
            IPaymentGateway gateway = null;

            switch (method)
            {
                case EPaymentMethod.BankOne:
                    gateway = new BankOne();
                    break;

                case EPaymentMethod.BankTwo:
                    gateway = new BankTwo();
                    break;

                default:
                    break;
            }

            return gateway;
        }
    }
}
