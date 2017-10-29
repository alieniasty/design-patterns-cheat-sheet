using System;

namespace ObserverWithEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var observable = new Observable();
            var observer = new Observer();
            observable.SomethingHappened += observer.HandleEvent;

            observable.DoSomething();

            Console.ReadLine();
        }
    }
}
