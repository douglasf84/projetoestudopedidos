using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class EnderecoMap : BaseDomainMap<Endereco>
    {
        EnderecoMap() : base("tb_endereco") { }

        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);
        }
    }
}
