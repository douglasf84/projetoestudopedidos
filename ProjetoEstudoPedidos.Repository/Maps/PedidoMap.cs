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
            builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(100).IsRequired();
            builder.Property(x => x.ValorTotal).HasColumnName("valor_total").HasPrecision(17, 2).IsRequired();

            builder.Property(x => x.Entrega).HasColumnName("entrega").IsRequired();
        }
    }
}
