using System.Data;
using System.Data.Entity;
using Vendas.Infrastructure;

namespace Vendas.Infrastructure
{
    public class SalesTransaction 
    {
        private SalesTransaction() {}
        public static DbContextTransaction CreateDbContextTransaction(SalesContext db)
        {
            return db.Database.BeginTransaction(IsolationLevel.ReadUncommitted);
        }
    }
}
