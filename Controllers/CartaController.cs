using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class CartaController : Controller
    {
        public IActionResult Carta()
        {
            return View();
        }
    }
}
