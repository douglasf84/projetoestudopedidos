using ProjetoEstudoPedidos.Domain;
using ProjetoEstudoPedidos.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEstudoPedidos.Repository
{

    public class ProdutoRepository : BaseRepository, IProdutoRepository
    { 
        private readonly ApplicationDbContext DbContext;
        
        public ProdutoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Produto> Get()
        {
            return DbContext.Produtos.ToList<Produto>();
        }
    }
}
