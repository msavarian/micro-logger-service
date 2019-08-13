# micro-logger-service
MicroService for logging and analysis logs in aspnetcore applications

### The project has two solution
1. an *API (nuget-package)* for send logs to rabbitmq 
2. a *microservice* for fetching logs from *rabbitmq* and store them to ElasticSearch

#### Finally you can view and analys the logs with kibana


## How to Use API
1. Install nuget package 
``` 
Install-Package MicroLogger.API_Serilog.Standard -Version 1.0.5
```
2. Register the API services in startup.cs class file
```
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMicroLogger(new MicroLogger.API.DomainClasses.MessageBrokerInfoInputModel
            {
                ClientName = "<YourMicroServiceName(Use4ConnectionName)>",
                HostName = "127.0.0.1",
                Port = 15672,
                Username = "guest",
                Password = "guest"
            });
            // ...
            // ...
            // ...
```
3. Use the APIs in controllers
```
    public class HomeController : Controller
    {
        private readonly IMicroLogger logger;
        public HomeController(IMicroLogger logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.Info(new LogModel { Message="test msg" });
            logger.Error(new LogModel { Message = "test msg" });
            logger.Warn(new LogModel { Message = "test msg" });
            return View();
        }
```
---
## How to Use MicroService
**It's not Complete yet**

