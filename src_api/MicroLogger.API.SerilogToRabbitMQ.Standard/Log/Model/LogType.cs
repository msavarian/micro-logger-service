namespace MicroLogger.API.SerilogToRabbitMQ.Standard.Log.Model
{
    /// <summary>
    /// نوع لاگ
    /// </summary>
    public enum LogType
    {
        Custom_LOG = 1,

        Security_LOG = 2,

        LoginAudit_LOG = 3,

        Application_LOG = 4,

        Server_LOG = 5,

        DatabaseCommands_LOG = 6

    }
}
