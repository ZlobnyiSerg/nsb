using System;
using nsb.messages;
using NServiceBus;

namespace nsb.subscriber
{
    public class TestMessageHandler : IHandleMessages<TestMessage>
    {
        public void Handle(TestMessage message)
        {
            Console.WriteLine("Received test message {0}, creation date {1}", message.Id, message.CreateDate);
        }
    }
}