using Microsoft.EntityFrameworkCore;
using ProjetoEstudoPedidos.Domain;
using ProjetoEstudoPedidos.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEstudoPedidos.Repository
{

    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {

        public ProdutoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }     

        public List<Produto> Get()
        {
            return DbContext.Produtos
                .Include(x => x.Categoria)
                .Where(x => x.Ativo)
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public List<Produto> Search(string text, int pagina)
        {
            return DbContext.Produtos
                .Include(x => x.Categoria)
                .Where(x => x.Ativo 
                && (x.Nome.ToUpper().Contains(text.ToUpper())
                || x.Descricao.ToUpper().Contains(text.ToUpper())))
                .Skip(TamanhoPagina*(pagina-1))
                .Take(TamanhoPagina)
                .OrderBy(x=> x.Nome)
                .ToList();
        }

        public Produto Detail(int id)
        {
            return DbContext.Produtos
                .Include(x => x.Imagems)
                .Include(x => x.Categoria)
                .Where(x => x.Ativo && x.Id == id)
                .FirstOrDefault();
        }
    }
}
