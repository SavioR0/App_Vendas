
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using Vendas.Entity;
using Vendas.Entity.Entities;

namespace app2.data
{
    public class SalesContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<User> Client { get; set; }
        public DbSet<Sale> Sale { get; set; }


        public SalesContext() : base(@"Data Source=PROGRAMACAO51\SQLEXPRESS;Initial Catalog=vendas;User Id=sa;Password=senh@123;Integrated Security=False;Persist Security Info=True;Multipleactiveresultsets=True;")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
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
