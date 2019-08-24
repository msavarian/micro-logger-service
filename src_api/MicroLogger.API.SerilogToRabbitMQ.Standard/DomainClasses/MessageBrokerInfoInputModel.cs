using System;
using RabbitMQ.Client;

namespace MicroLogger.API.SerilogToRabbitMQ.Standard.DomainClasses
{
    public class MessageBrokerInfoInputModel
    {
        /// <summary>
        /// نام برنامه استفاده کننده
        /// </summary>
        public string ClientName { get; set; } = "No-Client-Name";


        public string HostName { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 15672;


        public string Username { get; set; } = "guest";
        public string Password { get; set; } = "guest";

    }
}
