namespace ChainOfResponsibility
{
    interface IRequestHandler
    {
        string Name { get; set; }
        void HandleRequest(LoanRequest req);
        IRequestHandler Successor { get; set; }
    }
}
