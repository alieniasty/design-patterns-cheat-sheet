using System.Threading.Tasks;
using PublisherSubscriber.Common;

namespace Subscriber
{
    public interface ISubscriberService
    {
        Task<bool> ReceiveMsgAsync(MessageEventArgs msg);
    }
}
