
using NServiceBus;
using NServiceBus.Persistence;

namespace nsb.subscriber
{
    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
    public class EndpointConfig : IConfigureThisEndpoint
    {
        void IConfigureThisEndpoint.Customize(BusConfiguration config)
        {
            config.UseTransport<SqlServerTransport>();
            config.UsePersistence<NHibernatePersistence, StorageType.Sagas>();
            config.UsePersistence<NHibernatePersistence, StorageType.Subscriptions>();
            config.UsePersistence<NHibernatePersistence, StorageType.Timeouts>();
            config.UsePersistence<NHibernatePersistence, StorageType.Outbox>();
        }
    }
}
