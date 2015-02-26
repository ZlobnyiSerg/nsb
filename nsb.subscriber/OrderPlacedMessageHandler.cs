using System;
using nsb.messages;
using NServiceBus;

namespace nsb_client
{
    public class OrderPlacedMessageHandler : IHandleMessages<OrderPlacedMessage>
    {
        public void Handle(OrderPlacedMessage message)
        {
            Console.WriteLine("Received notification about processing order " + message.Id);
        }
    }
}