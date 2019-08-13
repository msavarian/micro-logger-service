using System;
using System.Collections.Generic;
using System.Text;

namespace MicroLogger.API_Serilog.Standard.Log.Model
{
    public class LogModel
    {
        public string Message { get; set; }
        public LogType LogType { get; set; }
        public DateTime LogDateTime { get; set; }

    }
}
