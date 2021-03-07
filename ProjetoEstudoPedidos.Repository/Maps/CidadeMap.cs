using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class CidadeMap : BaseDomainMap<Cidade>
    {
        CidadeMap() : base("tb_cidade") { }

        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);
        }
    }
}
