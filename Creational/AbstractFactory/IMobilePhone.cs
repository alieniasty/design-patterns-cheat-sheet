namespace AbstractFactory
{
    /*Abstract factory*/
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        IOldPhone GetOldPhone();
    }
}