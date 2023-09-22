using app2.data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Repository.Intefaces;

namespace Vendas.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _context;
        private DbSet<T> _dbSet {
            get { return _context.Set<T>(); }}
        public Repository(DbContext context)
        {
            _context = context;
        }

        public string Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> Filter(Expression<System.Func<T, bool>> condition)
        {
            return _dbSet.Where(condition);
        }

        public IQueryable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public SalesContext GetContext()
        {
            throw new System.NotImplementedException();
        }

        public string Insert(T entity)
        {
            _dbSet.Add(entity);
            return SaveChanges();
        }

        public string SaveChanges()
        {
            return "";
        }

        private void MarkModified(T entity) 
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public string Update(T entity)
        {
            MarkModified(entity);
            return SaveChanges();
        }

        DbContext IRepository<T>.GetContext()
        {
            return _context;
        }
    }
}
