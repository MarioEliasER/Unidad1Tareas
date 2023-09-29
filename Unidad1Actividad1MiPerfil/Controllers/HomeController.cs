using Microsoft.AspNetCore.Mvc;

namespace Unidad1Actividad1MiPerfil.Controllers
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
