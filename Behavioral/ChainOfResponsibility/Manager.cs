using System;

namespace ChainOfResponsibility
{
    class Manager : IRequestHandler
    {
        public IRequestHandler Successor { get; set; }
        public string Name { get; set; }


        public void HandleRequest(LoanRequest req)
        {
            if (req.Amount < 10000)
                Console.WriteLine("{0} $$ Loan approved for {1} - Approved by {2}",
                    req.Amount, req.Customer, Name);
            else
                this.TrySuccessor(req);
        }
    }
}
