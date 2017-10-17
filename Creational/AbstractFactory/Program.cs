using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobilePhone mobilePhone = new Nokia();
            
            var nokiaClient = new Client(mobilePhone);
            
            Console.WriteLine(nokiaClient.GetOldPhone());
            Console.WriteLine(nokiaClient.GetSmartPhone());

            Console.Read();
        }
    }
}