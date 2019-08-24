
namespace MicroLogger.API.SerilogToRabbitMQ.Standard.DomainClasses
{
    public class AppConstants
    {
        public static MessageBrokerInfoInputModel RabbitMQInfo { get; set; }

        public readonly static string RabitMqExchange = "MicroLogger-Exchange";
        public readonly static MicroLib.RabbitMQ.Client.Helper.Standard.Model.ExchangeType 
            RabitMqExchangeType = MicroLib.RabbitMQ.Client.Helper.Standard.Model.ExchangeType.Direct;
        
        public readonly static string RabitMqQueueName = "MicroLogger-Queue";
        public readonly static string RabitMqRouteKey = "MicroLogger-RouteKey";
    }
}
