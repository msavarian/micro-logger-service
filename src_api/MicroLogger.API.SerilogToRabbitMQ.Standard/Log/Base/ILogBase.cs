using MicroLogger.API.SerilogToRabbitMQ.Standard.Log.Model;

namespace MicroLogger.API.SerilogToRabbitMQ.Standard.Log.Base
{
    public interface ILogBase
    {
        void Log(LogModel log);
    }
}