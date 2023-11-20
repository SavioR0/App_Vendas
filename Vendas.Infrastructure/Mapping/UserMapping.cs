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
            Property(p => p.LastName).HasMaxLength(100).IsOptional();
            Property(p => p.Email).HasMaxLength(100).IsOptional();
            Property(p => p.Password).IsRequired().HasMaxLength(50);
            Property(p => p.Cpf).HasMaxLength(11);
            Property(p => p.Tel).HasMaxLength(20);
            Property(p => p.DateOfBirth).IsOptional(); 
            Property(p => p.EditLogin).IsOptional(); 
            Property(p => p.TypeUser).IsOptional(); 
            Property(p => p.AddressId).IsOptional();
            Property(p => p.BiometryDataBinary).HasColumnType("varbinary(max)").IsOptional();
            Property(p => p.BiometryDataText).IsOptional();
            Property(p => p.Flag).IsRequired();

            HasOptional(p => p.Address).WithMany(p=>p.Users).HasForeignKey(v => v.AddressId);
            HasOptional(p => p.TypeUsers).WithMany(p => p.Users).HasForeignKey(v => v.TypeUser);


        }
    }
}
