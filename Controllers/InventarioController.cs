using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class InventarioController : Controller
    {
        public IActionResult Inventario()
        {
            return View();
        }
    }
}
