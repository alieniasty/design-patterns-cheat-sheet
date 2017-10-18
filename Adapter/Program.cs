using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var strangeClass = new SomeStrangeClass();
            var listener = new SomeStrangeClassAdapter(strangeClass);

            listener.Notify("Tiruriru");

            Console.ReadLine();
        }
    }
}