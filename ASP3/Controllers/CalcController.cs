using ASP3.Models;
using ASP3.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP3.Controllers
{
    public class CalcController : Controller
    {
        private CalcService _calcService;
        public CalcController(CalcService calcService) 
        {
            _calcService = calcService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return Ok(_calcService.Plus(11, 2));
        }

        [HttpGet]
        public IActionResult Minus()
        {
            return Ok(_calcService.Minus(11, 2));
        }
        [HttpGet]
        public IActionResult Divide()
        {
            try
            {
                return Ok(_calcService.Divide(11, 2));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Mult()
        {
            return Ok(_calcService.Mult(11, 2));
        }
        [HttpGet]
        public IActionResult Max()
        {
            return Ok(_calcService.Max(11, 2));
        }
        [HttpGet]
        public IActionResult Min()
        {
            return Ok(_calcService.Min(11, 2));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
