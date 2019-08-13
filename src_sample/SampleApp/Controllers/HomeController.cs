using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MicroLogger.API_Serilog.Standard.Log;
using MicroLogger.API_Serilog.Standard.Log.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
