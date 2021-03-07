using ProjetoEstudoPedidos.Domain;
using System.Collections.Generic;

namespace ProjetoEstudoPedidos.Interface
{
    public interface IProdutoRepository
    {
        List<Produto> Get();
    }
}
