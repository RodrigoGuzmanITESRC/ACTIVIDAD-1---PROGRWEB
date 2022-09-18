
using ACTIVIDAD_2___PROGRWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACTIVIDAD_2___PROGRWEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(float c1, float c2, float c3)
        {
            PromedioViewModel pc = new PromedioViewModel();
            pc.Calificacion1 = c1;
            pc.Calificacion2 = c2;
            pc.Calificacion3 = c3;

            return View(pc);

        }

    }
}
