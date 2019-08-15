using Micro.Serilog.Sinks.RabbitMQ;
using MicroLogger.API.DomainClasses;
using MicroLogger.API_Serilog.Standard.Log;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Formatting.Json;

namespace MicroLogger.API_Serilog.Standard
{
    public static partial class _IocExtention
    {
        public static void AddMicroLogger(this IServiceCollection services, MessageBrokerInfoInputModel messageBrokerInfoModel)
        {
            // store rabbitmq parameters
            AppConstants.RabbitMQInfo = messageBrokerInfoModel;
            services.AddSingleton<IMicroLogger, MicroLogger.API_Serilog.Standard.Log.MicroLogger>();
        }

    }
}