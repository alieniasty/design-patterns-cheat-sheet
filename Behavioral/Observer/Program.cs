using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern */

            BaggageProvider provider = new BaggageProvider();
            BaggageObserver observer1 = new BaggageObserver("BaggageClaimMonitor");
            BaggageObserver observer2 = new BaggageObserver("SecurityExit");

            provider.BaggageStatus(712, "Detroit", 3);
            observer1.Subscribe(provider);
            provider.BaggageStatus(712, "Kalamazoo", 3);
            provider.BaggageStatus(400, "New York-Kennedy", 1);
            provider.BaggageStatus(712, "Detroit", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "San Francisco", 2);
            provider.BaggageStatus(712);
            observer2.Unsubscribe();
            provider.BaggageStatus(400);
            provider.LastBaggageClaimed();

            Console.ReadLine();
        }
    }
}
