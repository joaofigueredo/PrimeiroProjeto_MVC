using PrimeiroProjeto_MVC.Context;
using PrimeiroProjeto_MVC.Models;
using PrimeiroProjeto_MVC.Repositories.Interfaces;

namespace PrimeiroProjeto_MVC.Repositories

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
