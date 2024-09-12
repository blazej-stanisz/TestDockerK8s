using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Diagnostics;
using TestDockerK8s.Helpers;
using TestDockerK8s.Models;

namespace TestDockerK8s.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IDataAccess dataAccess;

        public HomeController(ILogger<HomeController> logger, IDataAccess dataAccess)
        {
            this._logger = logger;
            this.dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            var clientName = string.Empty;

            try
            {
                var clientNames = dataAccess.GetClientNames();
                clientName = clientNames.First().ClientName;
            }
            catch { }

            ViewBag.ClientName = clientName != string.Empty ? clientName : "Backend";
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
