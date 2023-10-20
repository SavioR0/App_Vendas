using System.Data.Entity.ModelConfiguration;
using Vendas.Entity.Entities;

namespace vendas.model.mapping
{
    class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping() {
            ToTable("Usuarios");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Email).IsRequired().HasMaxLength(100);
            Property(p => p.Password).IsRequired().HasMaxLength(50);
            Property(p => p.TypeUser).IsRequired();
            Property(p => p.Cpf).IsRequired().HasMaxLength(11);
            Property(p => p.Tel).IsRequired().HasMaxLength(20);
            Property(p => p.DateOfBirth);
            Property(p => p.EditLogin);
            Property(p => p.AddressId);
            Property(p => p.BiometryDataBinary).HasColumnType("varbinary(max)");
            Property(p => p.BiometryDataText);

            HasRequired(p => p.Address).WithMany(p=>p.Users).HasForeignKey(v => v.AddressId);


        }
    }
}
