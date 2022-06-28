using APICatalogo.Models;
using APICatalogo.Context;
using Microsoft.EntityFrameworkCore;
using APICatalogo.Pagination;

namespace APICatalogo.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(APICatalogoContext context) : base(context)
        {
        }

        public PagedList<Categoria> GetCategorias(CategoriasParameters parameters)
        {
            return PagedList<Categoria>.ToPagedList(Get().OrderBy(on => on.Nome),
                parameters.PageNumber,
                parameters.PageSize);
        }

        public IEnumerable<Categoria> GetCategoriasProdutos()
        {
            return Get().Include(x => x.Produtos);
        }
    }
}
