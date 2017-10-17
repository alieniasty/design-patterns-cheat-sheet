namespace AbstractFactory
{
    /*
     * Abstract factory that returns abstract products. 
     */

    public interface IMobilePhone
    {                        
        ISmartPhone GetSmartPhone();
        IOldPhone GetOldPhone();
    }
}