using ASP3.Models;
using ASP3.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TimeService _timeService;

        public HomeController(ILogger<HomeController> logger, TimeService timeService)
        {
            _logger = logger;
            _timeService = timeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetTime()
        {
            return Ok(_timeService.TimeAnalysis());
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
