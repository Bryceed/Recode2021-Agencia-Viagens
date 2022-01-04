using Microsoft.AspNetCore.Mvc;

namespace WellN_M2_AgenciaViagens.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
