using Micro.Serilog.Sinks.RabbitMQ;
using MicroLogger.API.SerilogToRabbitMQ.Standard.DomainClasses;
using MicroLogger.API.SerilogToRabbitMQ.Standard.Log.Model;
using Newtonsoft.Json;
using Serilog;

namespace MicroLogger.API.SerilogToRabbitMQ.Standard.Log
{
    public class MicroLogger : IMicroLogger
    {
        private readonly Serilog.Core.Logger _serilogLogger;
        public MicroLogger()
        {
            // config serilog
            _serilogLogger = new LoggerConfiguration()
                //.Enrich.FromLogContext()
                //.WithProperty("App Name", "WebApp")
                //.MinimumLevel.Information()
                .MinimumLevel.ControlledBy(new Serilog.Core.LoggingLevelSwitch(Serilog.Events.LogEventLevel.Verbose))

                .WriteTo.MySink(new SinkConfiguration
                {
                    ClientName = AppConstants.RabbitMQInfo.ClientName,
                    RabbitMqHostName = AppConstants.RabbitMQInfo.HostName,
                    RabbitMqPort = AppConstants.RabbitMQInfo.Port,
                    RabbitMqUsername = AppConstants.RabbitMQInfo.Username,
                    RabbitMqPassword = AppConstants.RabbitMQInfo.Password,

                    RabbitMqExchangeName = AppConstants.RabitMqExchange,
                    RabbitMqExchangeType = AppConstants.RabitMqExchangeType,
                    RabbitMqRouteKey = AppConstants.RabitMqRouteKey,
                    RabbitMqQueueName = AppConstants.RabitMqQueueName
                })
                .CreateLogger();
        }



        #region "Helper Methods"        
        public void Debug(LogModel logModel)
        {
            _serilogLogger.Debug(JsonConvert.SerializeObject(logModel));
        }

        public void Info(LogModel logModel)
        {
            _serilogLogger.Information(JsonConvert.SerializeObject(logModel));
        }

        public void Warn(LogModel logModel)
        {
            _serilogLogger.Warning(JsonConvert.SerializeObject(logModel));
        }

        public void Error(LogModel logModel)
        {
            _serilogLogger.Error(JsonConvert.SerializeObject(logModel));
        }

        public void Fatal(LogModel logModel)
        {
            _serilogLogger.Fatal(JsonConvert.SerializeObject(logModel));
        }
        #endregion



    }
}