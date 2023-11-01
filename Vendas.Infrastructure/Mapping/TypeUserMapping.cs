using System.Data.Entity.ModelConfiguration;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure.Mapping
{
    class TypeUserMapping : EntityTypeConfiguration<TypeUsers>
    {
        public TypeUserMapping()
        {
            ToTable("TipoUsuarios");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired();
        }
    }
}
