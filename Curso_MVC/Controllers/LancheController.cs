using Curso_MVC.Repositories;
using Curso_MVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Curso_MVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            ViewData["Título"] = "Todos os lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();

            ViewBag.Total = "Total de lanches";
            ViewBag.TotalLanches = totalLanches;

            return View(lanches);
        }
    }
}
