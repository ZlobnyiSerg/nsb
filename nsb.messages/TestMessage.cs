using System;
using NServiceBus;

namespace nsb.messages
{
    public class TestMessage : IEvent
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public TestMessage(Guid id)
        {
            Id = id;
            CreateDate = DateTime.Now;
        }
    }
}