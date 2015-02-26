using System;
using System.Linq;
using nsb.messages;
using NServiceBus;

namespace nsb_client
{
    public class SendOrder : IWantToRunWhenBusStartsAndStops
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

                //Bus.Publish(new OrderPlacedMessage{Id = Guid.NewGuid()});
                Bus.Send(new PlaceOrderCommand(id, "Some product"));

                /*PlaceOrderResponse response = null;
                var asyncResult =
                    Bus.Send("nsb", new PlaceOrderCommand {Product = "New shoes", Id = id}).Register(c =>
                    {
                        Console.WriteLine("Reply received!");
                        var completionResult = c.AsyncState as CompletionResult;
                        if (completionResult != null && completionResult.Messages.Any())
                        {
                            response = completionResult.Messages.First() as PlaceOrderResponse;                             
                        }
                    }, null);                    
                asyncResult.AsyncWaitHandle.WaitOne();
                if (response != null)
                {
                    Console.WriteLine("Response received: {0}", response);
                }*/
            }
        }
        public void Stop()
        {
        }
    }
}
