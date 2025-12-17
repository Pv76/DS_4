using Microsoft.AspNetCore.Mvc;

namespace Parcial3.Controllers
{
    public class RevistasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
