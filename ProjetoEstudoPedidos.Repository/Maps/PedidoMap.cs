using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class PedidoMap : BaseDomainMap<Pedido>
    {
        PedidoMap() : base("tb_pedido") { }

        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);
        }
    }
}
