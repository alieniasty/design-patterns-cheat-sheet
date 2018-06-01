using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PublisherSubscriber.Common;

namespace Subscriber
{
    public interface IRemoteService
    {
        Task<HttpStatusCode> ReceiveMsgAsync(MessageEventArgs msg);
    }
}
