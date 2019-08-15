using MicroLogger.API_Serilog.Standard.Log.Model;

namespace MicroLogger.API_Serilog.Standard.Log.Base
{
    public interface ILogBase
    {
        void Log(LogModel log);
    }
}