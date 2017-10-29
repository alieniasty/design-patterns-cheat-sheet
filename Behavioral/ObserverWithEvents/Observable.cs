using System;

namespace ObserverWithEvents
{
    internal class Observable
    {
        public event EventHandler SomethingHappened;

        public void DoSomething()
        {
            SomethingHappened?.Invoke(this, EventArgs.Empty);
        }
    }
}
