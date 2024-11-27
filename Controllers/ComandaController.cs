using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class ComandaController : Controller
    {
        public IActionResult Comanda()
        {
            return View();
        }
    }
}
