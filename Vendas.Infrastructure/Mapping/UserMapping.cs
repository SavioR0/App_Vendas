using System.Data.Entity.ModelConfiguration;
using Vendas.Entity.Entities;

namespace vendas.model.mapping
{
    class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping() {
            ToTable("Usuários");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Cpf).IsRequired().HasMaxLength(11);
            Property(p => p.Tel).IsRequired().HasMaxLength(20);
            Property(p => p.DateOfBirth).IsRequired();
            //OwnsOne(p => p.Adress, address =>
            //{
            //    address.Property(a => a.Street).IsRequired().HasMaxLength(100);
            //    address.Property(a => a.City).IsRequired().HasMaxLength(100);
            //    address.Property(a => a.State).IsRequired().HasMaxLength(50);
            //    address.Property(a => a.ZipCode).IsRequired().HasMaxLength(10);
            //});
        }
    }
}
