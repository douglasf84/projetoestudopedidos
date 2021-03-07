using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class ProdutoPedidoMap : BaseDomainMap<ProdutoPedido>
    {
        ProdutoPedidoMap() : base("tb_produto_pedido") { }

        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);
        }
    }
}
