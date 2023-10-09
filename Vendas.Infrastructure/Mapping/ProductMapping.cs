using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure.Mapping
{
    class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            ToTable("Produtos");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.Stock).IsRequired();
            Property(p => p.Value).IsRequired();


            HasRequired(p => p.Seller).WithMany().HasForeignKey(v => v.SellerId);
        }
    }
}
