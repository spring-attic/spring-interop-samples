using System.Configuration;
using Spring.Messaging.Amqp.Core;
using Spring.Messaging.Amqp.Rabbit.Connection;
using Spring.Messaging.Amqp.Rabbit.Core;

namespace Spring.Interop.StockTraderSample.Client
{
    public static class BrokerConfiguration
    {
        public static void Configure()
        {
            using (IConnectionFactory connectionFactory = new CachingConnectionFactory())
            {
                IAmqpAdmin amqpAdmin = new RabbitAdmin(connectionFactory);

                //Each queue is automatically bound to the default direct exchange.      
                amqpAdmin.DeclareQueue(new Queue(ConfigurationManager.AppSettings["STOCK_REQUEST_QUEUE_NAME"]));
                amqpAdmin.DeclareQueue(new Queue(ConfigurationManager.AppSettings["STOCK_RESPONSE_QUEUE_NAME"]));

                //handled by the java server app on startup
                //TopicExchange mktDataExchange = new TopicExchange(ConfigurationManager.AppSettings["MARKET_DATA_EXCHANGE_NAME"], false, false);
                //amqpAdmin.DeclareExchange(mktDataExchange);

                var mktDataQueue = new Queue(ConfigurationManager.AppSettings["MARKET_DATA_QUEUE_NAME"]);
                amqpAdmin.DeclareQueue(mktDataQueue);
            }
        }
    }
}