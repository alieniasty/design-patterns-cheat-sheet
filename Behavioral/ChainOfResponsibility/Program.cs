using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Customers
            var request1 = new LoanRequest {Amount = 800, Customer = "Jimmy"};
            var request2 = new LoanRequest {Amount = 5000, Customer = "Ben"};
            var request3 = new LoanRequest {Amount = 200000, Customer = "Harry"};

            //Approvers, chained together
            var manager = new Manager {Name = "Tom, Manager"};
            var cashier = new Cashier {Name = "Job, Cachier", Successor = manager};

            //All customers request cashier first to approve
            cashier.HandleRequest(request1);
            cashier.HandleRequest(request2);
            cashier.HandleRequest(request3);

            Console.ReadLine();
        }
    }
}