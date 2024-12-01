using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class CajaController : Controller
    {
        public IActionResult Caja()
        {
            return View();
        }
    }
}
