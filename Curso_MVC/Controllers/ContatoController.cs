using Microsoft.AspNetCore.Mvc;

namespace Curso_MVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
