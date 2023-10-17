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
            Property(p => p.DateOfBirth).IsRequired();
            Property(p => p.EditLogin).IsRequired();
            Property(p => p.AddressId).IsRequired();
            Property(p => p.BiometricData).IsRequired().HasColumnType("varbinary(max)");


            HasRequired(p => p.Address).WithMany(p=>p.Users).HasForeignKey(v => v.AddressId);


        }
    }
}
