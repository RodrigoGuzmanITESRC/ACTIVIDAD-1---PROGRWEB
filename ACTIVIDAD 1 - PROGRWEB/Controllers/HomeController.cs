using Microsoft.AspNetCore.Mvc;

namespace ACTIVIDAD_1___PROGRWEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MiPerfil()
        {
            return View();
        }
    }
}
