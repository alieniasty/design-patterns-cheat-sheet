namespace AbstractFactory
{
    /*Concrete Factory*/
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