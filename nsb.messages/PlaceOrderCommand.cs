using System;
using NServiceBus;

namespace nsb.messages
{
    public class PlaceOrderCommand : ICommand
    {
        public Guid Id { get; set; }

        public string Product { get; set; }

        public PlaceOrderCommand(Guid id, string product)
        {
            Id = id;
            Product = product;
        }
    }
}
