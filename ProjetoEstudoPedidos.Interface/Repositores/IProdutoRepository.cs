using ProjetoEstudoPedidos.Domain;
using System.Collections.Generic;

namespace ProjetoEstudoPedidos.Interface
{
    public interface IProdutoRepository
    {
        List<Produto> Get();
        public List<Produto> Search(string text, int pagina);
        public Produto Detail(int id);
    }
}
