using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class CocinaController : Controller
    {
        public IActionResult Cocina()
        {
            return View();
        }
    }
}
