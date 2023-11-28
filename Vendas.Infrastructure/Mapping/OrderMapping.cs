using System.Data.Entity.ModelConfiguration;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure.Mapping
{
	class OrderMapping :EntityTypeConfiguration<Order>
	{
		public OrderMapping() {
			ToTable("Pedido");
			HasKey(c => c.Id);
			Property(c => c.SaleId).IsOptional();
			Property(c => c.ProductId).IsRequired();
			Property(c => c.Quantity).IsRequired();

			HasOptional(p => p.Sale)
				.WithMany(s => s.Orders)
				.HasForeignKey(p => p.SaleId);

			HasRequired(p => p.Product).
				WithMany().
				HasForeignKey(v => v.ProductId).
				WillCascadeOnDelete(false);
		}
	}
}
