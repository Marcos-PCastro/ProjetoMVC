using ProjetoMVC.Context;
using ProjetoMVC.Models;
using ProjetoMVC.Repositories.Interfaces;

namespace ProjetoMVC.Repositories
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
