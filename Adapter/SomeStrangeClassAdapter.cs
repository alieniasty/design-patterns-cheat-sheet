namespace Adapter
{
    public class SomeStrangeClassAdapter : IListener
    {
        private readonly SomeStrangeClass _adaptee;

        public SomeStrangeClassAdapter(SomeStrangeClass adaptee)
        {
            _adaptee = adaptee;
        }

        public void Notify(string info)
        {
            _adaptee.DoSomeStrangeShit(info);
        }
    }
}
