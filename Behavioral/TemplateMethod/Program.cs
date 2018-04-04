using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
             Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.              
             */

            AbstractClass first = new Categories();

            first.Run();
        }
    }
}
