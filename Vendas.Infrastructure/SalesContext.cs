
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure
{
    public class SalesContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<TypeUsers> TypeUsers { get; set; }
        public DbSet<Address> Addresses { get; set; }


        public SalesContext() : base(GetConnectionString("conectionString"))
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }
        public static string GetConnectionString(string connectionstringname)
        {
            var connectionstring = ConfigurationManager.ConnectionStrings[connectionstringname].ToString();
            return connectionstring;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public void Initialization() {
            TypeUsers.Add(new TypeUsers { Id = 1, Name = "Administrador" });
            TypeUsers.Add(new TypeUsers { Id = 3, Name = "Vendedor" });
            TypeUsers.Add(new TypeUsers { Id = 2, Name = "Cliente" });
            SaveChanges();
            // Verifica se não há usuários no banco
            if (!Users.Any())
            {
                // Adiciona um usuário
                var addMaster = new User {
                    Id = 1,
                    Name = "master",
                    Password = "c`afgd",
                    TypeUser = 1,
                    UserName = "Master",
                    EditLogin = 0,
                    Flag = "I",
                };
                Users.Add(addMaster);
                SaveChanges();
            }

        }
    }
}
