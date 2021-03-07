using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudoPedidos.Domain;

namespace ProjetoEstudoPedidos.Repository
{
    public class BaseDomainMap<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain : BaseDomain
    {
        public readonly string _tableName;
        
        public BaseDomainMap(string tableName = "")
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<TDomain> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.CriadoEm).HasColumnName("criado_em").IsRequired();
        }
    }
}
