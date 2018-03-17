namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        protected string ConnectionString;

        private void Connect()
        {
            ConnectionString =
                "provider=Microsoft.JET.OLEDB.4.0; " +
                "data source=..\\..\\..\\db1.mdb";
        }
        
        /*
        Connect() and Disconnect() are

        1. non-virtual and private since we want to force child class to use this implementation. 

        */

        private void Disconnect()
        {
            ConnectionString = "";
        }

        protected abstract void Process();

        public void Run()
        {
            Connect();
            Process();
            Disconnect();
        }
    }
}