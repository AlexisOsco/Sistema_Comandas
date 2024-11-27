using Microsoft.AspNetCore.Mvc;

namespace Sistema_Comandas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
