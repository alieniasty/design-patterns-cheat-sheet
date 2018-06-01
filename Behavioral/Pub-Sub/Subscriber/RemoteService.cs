using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using PublisherSubscriber.Common;

namespace Subscriber
{
    public class RemoteService : IRemoteService
    {
        public Task<HttpStatusCode> ReceiveMsgAsync(MessageEventArgs msg)
        {
            var task = Task.Run(() =>
            {
                if (string.IsNullOrEmpty(msg.Value))
                {
                    return HttpStatusCode.BadRequest;
                }
                return HttpStatusCode.OK;
            });

            Debug.WriteLine($"Message Delivered: {msg.Value}");

            return task;
        }
    }
}
