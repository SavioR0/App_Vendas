using System.Data.Entity.ModelConfiguration;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure.Mapping
{
    class AddressMapping : EntityTypeConfiguration<Address>
    {
        public AddressMapping()
        {
            ToTable("Endereços");
            HasKey(p => p.Id);

            Property(c => c.CEP).IsRequired().HasMaxLength(9);
            Property(p => p.City).IsRequired().HasMaxLength(100);
            Property(p => p.District).IsRequired().HasMaxLength(100);
            Property(p => p.Street).IsRequired().HasMaxLength(100);
            Property(p => p.Number).IsRequired();
        }
    }
}
