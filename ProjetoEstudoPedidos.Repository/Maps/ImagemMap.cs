using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class ImagemMap : BaseDomainMap<Imagem>
    {
        ImagemMap() : base("tb_imagem") { }

        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);
        }
    }
}
