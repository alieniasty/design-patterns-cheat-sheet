namespace AbstractFactory
{
    /*Concrete Factory that returns concrete product*/
    public class Nokia : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaSix();
        }

        public IOldPhone GetOldPhone()
        {
            return new Nokia3310();
        }
    }

}