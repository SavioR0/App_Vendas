
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using Vendas.Entity;
using Vendas.Entity.Entities;

namespace Vendas.Infrastructure
{
    public class SalesContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<User> Client { get; set; }
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
    }
}
