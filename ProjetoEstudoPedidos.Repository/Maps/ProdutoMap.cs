using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class ProdutoMap : BaseDomainMap<Produto>
    {
        ProdutoMap() : base("tb_produto") { }

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
        }
    }
}
