using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new AddressFacade();
            facade.SetAddress("Bydgoszcz", "ul. Kwiatowa", "85-000");
            Console.WriteLine(facade.GetAddress());
            Console.ReadLine();
        }
    }
}
