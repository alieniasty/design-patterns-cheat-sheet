using System;

namespace ChainOfResponsibility
{
    static class RequestHandlerExtension
    {
        public static void TrySuccessor(this IRequestHandler current, LoanRequest req)
        {

            if (current.Successor != null)
            {
                Console.WriteLine("{0} Can't approve - Passing request to {1}", current.Name, current.Successor.Name);
                current.Successor.HandleRequest(req);
            }
            else
            {
                Console.WriteLine("Amount invaid, no approval given");
            }
        }
    }
}
