using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WellN_M2_AgenciaViagens.Models;

namespace WellN_M2_AgenciaViagens.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Destinos()
        {
            return View();
        }
        public IActionResult Promocoes()
        {
            return View();
        }
        public IActionResult Contato()
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