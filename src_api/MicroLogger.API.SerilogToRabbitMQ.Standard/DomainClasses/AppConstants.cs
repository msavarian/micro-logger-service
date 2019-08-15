
namespace MicroLogger.API.DomainClasses
{
    public class AppConstants
    {
        public static MessageBrokerInfoInputModel RabbitMQInfo { get; set; }

        public readonly static string RabitMqExchange = "MicroLogger-Exchange";
        public readonly static string RabitMqExchangeType = RabbitMQ.Client.ExchangeType.Direct;
        
        public readonly static string RabitMqQueueName = "MicroLogger-Queue";
        public readonly static string RabitMqRouteKey = "MicroLogger-RouteKey";
    }
}
