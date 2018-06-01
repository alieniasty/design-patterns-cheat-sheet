using System;

namespace PublisherSubscriber.Common
{
    public class MessageEventArgs : EventArgs
    {
        public string Value { get; set; }
    }
}
