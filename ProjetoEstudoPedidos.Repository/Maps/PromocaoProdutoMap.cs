using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class PromocaoProdutoMap : BaseDomainMap<PromocaoProduto>
    {
        PromocaoProdutoMap() : base("tb_promocao_produto") { }

        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            base.Configure(builder);
        }
    }
}
