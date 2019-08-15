using MicroLogger.API_Serilog.Standard.Log.Model;

namespace MicroLogger.API_Serilog.Standard.Log
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