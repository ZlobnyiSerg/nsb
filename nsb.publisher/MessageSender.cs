using System;
using nsb.messages;
using NServiceBus;

namespace nsb.publisher
{
    public class MessageSender : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }

        public void Start()
        {
            Console.WriteLine("Press 'Enter' to send a message.To exit, Ctrl + C");

            while (Console.ReadLine() != null)
            {
                var id = Guid.NewGuid();

                Console.WriteLine("==========================================================================");
                Console.WriteLine("Send a new PlaceOrderCommand message with id: {0}", id.ToString("N"));
                
                Bus.Send(new TestMessage(id));
            }
        }

        public void Stop()
        {         
        }
    }
}