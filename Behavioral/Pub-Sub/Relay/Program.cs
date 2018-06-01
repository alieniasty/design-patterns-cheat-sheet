using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PublisherSubscriber.Common;
using Subscriber;

namespace Relay
{
    class Program
    {
        static void Main(string[] args)
        {
            var relay = new Relay();
            List<Task<bool>> messagesSent = new List<Task<bool>>();

            string messageToPass;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Hello I am relay, pass me message to Subscriber {i}.");

                messageToPass = Console.ReadLine();
                var msg = new MessageEventArgs
                {
                    Value = messageToPass
                };

                // this should go to subscriber as he is the one who reacts to the event 
                // and then inside this method, simple console write message
                relay.OnChange += (sender, e) =>
                {
                    var subscriber = new SubscriberService(new RemoteService());
                    messagesSent.Add(subscriber.ReceiveMsgAsync(msg));
                };
            }

            Console.WriteLine("Trigger messages with any button");
            Console.ReadLine();
            relay.SendMessages();

            Task.WhenAll(messagesSent);

            // Ensure all messages delivered without errors
            foreach (var message in messagesSent)
            {
                if (message.Result != false)
                {
                    Console.WriteLine($"Message delivered! See output window for messages logged by Subscribers.");
                }
            }

            Console.ReadLine();
        }
    }
}
