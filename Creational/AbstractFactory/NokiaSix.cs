namespace AbstractFactory
{
    /*Concrete Product*/
    public class NokiaSix : ISmartPhone
    {
        public string GetDetails()
        {
            return "Nokia 6 smartphone. Very solid, hell yeah";
        }
    }
}