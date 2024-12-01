using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class ListaPreciosController : Controller
    {
        public IActionResult ListaPrecios()
        {
            return View();
        }
    }
}
