namespace AbstractFactory
{
    public class Client
    {
        private readonly ISmartPhone _smartPhone;

        private readonly IOldPhone _oldPhone;

        public Client(IMobilePhone factory)
        {
            _smartPhone = factory.GetSmartPhone();
            _oldPhone = factory.GetOldPhone();
        }

        public string GetSmartPhone()
        {
            return _smartPhone.GetDetails();
        }
        
        public string GetOldPhone()
        {
            return _oldPhone.GetDetails();
        }
    }
}