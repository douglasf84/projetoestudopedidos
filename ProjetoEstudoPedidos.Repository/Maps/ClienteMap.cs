using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        ClienteMap() : base("tb_cliente") { }

        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
        }
    }
}
