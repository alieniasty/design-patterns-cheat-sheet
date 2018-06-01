using PublisherSubscriber.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relay
{
    public class Relay
    {
        public event EventHandler<MessageEventArgs> OnChange = delegate { };

        // this should be called by the publisher with an argument of MessageEventArgs and optional Publisher object
        public void SendMessages()
        {
            //Pass this and empty message only to trigger all events
            OnChange(this, new MessageEventArgs());
        }
    }
}
