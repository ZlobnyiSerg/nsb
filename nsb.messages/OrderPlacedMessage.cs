using System;
using NServiceBus;

namespace nsb.messages
{
    public class OrderPlacedMessage : IEvent
    {
        public Guid Id { get; set; }

        public OrderPlacedMessage(Guid id)
        {
            Id = id;
        }
    }
}