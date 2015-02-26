using System;
using System.Transactions;
using nsb.messages;
using NServiceBus;

namespace nsb
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrderCommand>
    {
        public IBus Bus { get; set; }

        public void Handle(PlaceOrderCommand message)
        {            
            Console.WriteLine(@"Order for Product:{0} placed with id: {1}", message.Product, message.Id);
            Bus.Publish(new OrderPlacedMessage(message.Id));
        }
    }
}
