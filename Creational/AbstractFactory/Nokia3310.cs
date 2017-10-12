namespace AbstractFactory
{
    /*Concrete product*/
    public class Nokia3310 : IOldPhone
    {
        public string GetDetails()
        {
            return "Nokia 3310. Very solid, but a little bit rusty";
        }
    }
}