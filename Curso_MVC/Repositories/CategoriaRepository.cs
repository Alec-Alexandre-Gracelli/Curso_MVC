using Curso_MVC.Context;
using Curso_MVC.Models;
using Curso_MVC.Repositories.Interfaces;

namespace Curso_MVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
