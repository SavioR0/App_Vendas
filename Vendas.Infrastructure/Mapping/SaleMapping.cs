using System.Data.Entity.ModelConfiguration;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure.Mapping
{
    class SaleMapping : EntityTypeConfiguration<Sale>
    {
        public SaleMapping() {
            ToTable("Vendas");
            HasKey(p => p.Id);
            Property(p => p.Flag).IsRequired();

            HasRequired(p => p.Product).WithMany().HasForeignKey(v => v.ProductId).WillCascadeOnDelete(false);
            HasRequired(p => p.Client).WithMany().HasForeignKey(v => v.ClientId).WillCascadeOnDelete(false);
            HasRequired(p => p.Seller).WithMany().HasForeignKey(v => v.SellerId).WillCascadeOnDelete(false);
        }
    }
}
