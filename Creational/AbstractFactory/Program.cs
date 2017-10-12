using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobilePhone mobilePhone = new Nokia();
            
            var nokiaClient = new Client(mobilePhone);
            
            Console.WriteLine(nokiaClient.GetOldPhoneDetails());
            Console.WriteLine(nokiaClient.GetSmartPhoneDetails());

            Console.Read();
        }
    }
}