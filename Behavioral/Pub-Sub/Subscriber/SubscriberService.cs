using System.Net;
using System.Threading.Tasks;
using PublisherSubscriber.Common;

namespace Subscriber
{
    public class SubscriberService : ISubscriberService
    {
        private IRemoteService _remoteService;

        public SubscriberService(IRemoteService remoteService)
        {
            _remoteService = remoteService;
        }

        public async Task<bool> ReceiveMsgAsync(MessageEventArgs msg)
        {
            var task = Task.Run(async () =>
            {
                return await _remoteService.ReceiveMsgAsync(msg) == HttpStatusCode.OK;
            });

            return await task;
        }
    }
}
