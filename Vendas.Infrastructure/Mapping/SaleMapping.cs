using System.Data.Entity.ModelConfiguration;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure.Mapping
{
    class SaleMapping : EntityTypeConfiguration<Sale>
    {
        public SaleMapping() {
            ToTable("Vendas");
            HasKey(p => p.Id);
            Property(p => p.ClientId).IsRequired();
            Property(p => p.DateSale).IsRequired();

            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(v => v.ClientId)
                .WillCascadeOnDelete(false);

        }
    }
}
