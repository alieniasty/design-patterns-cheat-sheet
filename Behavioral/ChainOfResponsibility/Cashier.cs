using System;

namespace ChainOfResponsibility
{
    class Cashier : IRequestHandler
    {
        public string Name { get; set; }

        public void HandleRequest(LoanRequest req)
        {
            Console.WriteLine("\n----\n{0} $$ Loan Requested by {1}",
                req.Amount, req.Customer);

            if (req.Amount < 1000)
                Console.WriteLine("{0} $$ Loan approved for {1} - Approved by {2}",
                    req.Amount, req.Customer, Name);
            else
                this.TrySuccessor(req);
        }

        public IRequestHandler Successor { get; set; }
    }
}
