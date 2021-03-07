using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class ComboMap : BaseDomainMap<Combo>
    {
        ComboMap() : base("tb_combo") { }

        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
            base.Configure(builder);
        }
    }
}
