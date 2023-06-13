using Curso_MVC.Models;
using Curso_MVC.Repositories;
using Curso_MVC.Repositories.Interfaces;
using Curso_MVC.ViewModels;
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

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                              .Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                              .OrderBy(l => l.Nome);
                }
                else if (string.Equals("Natural", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                              .Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                              .OrderBy(l => l.Nome);
                }
                else
                {
                    throw new Exception();
                }
                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
            return View(lanchesListViewModel);
        }
    }
}
