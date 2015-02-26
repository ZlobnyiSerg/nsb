using System;
using NServiceBus;

namespace nsb.messages
{
    public class PlaceOrderResponse : IMessage
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}