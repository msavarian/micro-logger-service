using MicroLogger.API.SerilogToRabbitMQ.Standard.Log.Model;

namespace MicroLogger.API.SerilogToRabbitMQ.Standard.Log
{
    public interface IMicroLogger
    {
        void Debug(LogModel logModel);
        void Error(LogModel logModel);
        void Fatal(LogModel logModel);
        void Info(LogModel logModel);
        void Warn(LogModel logModel);
    }
}