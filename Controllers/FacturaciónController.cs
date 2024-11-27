using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class FacturaciónController : Controller
    {
        public IActionResult Facturacion()
        {
            return View();
        }
    }
}
