using app2.data;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Repository.Intefaces;

namespace Vendas.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet {
            get { return _dbContext.Set<T>(); }}
        public Repository(DbContext context)
        {
            _dbContext = context;
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
            try
            {
                _dbContext.SaveChanges();
                return "";
            }
            catch (DbEntityValidationException erro)
            {
                string mensagem = "";
                foreach (DbEntityValidationResult entityvalidationErrors in erro.EntityValidationErrors)
                    foreach (DbValidationError validationError in entityvalidationErrors.ValidationErrors)
                        mensagem += string.Format("Entidade: {0} \n\rPropriedade: {1} \n\rErro: {2}\n\r", entityvalidationErrors.Entry, validationError.PropertyName, validationError.ErrorMessage);
                return mensagem;
            }
            catch (Exception erro)
            {
                if (erro.InnerException != null)
                {
                    if (erro.InnerException.InnerException != null)
                        return erro.InnerException.InnerException.Message;
                    return erro.InnerException.Message;
                }
                return erro.Message;
            }
        }

        private void MarkModified(T entity) 
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        public string Update(T entity)
        {
            MarkModified(entity);
            return SaveChanges();
        }

        DbContext IRepository<T>.GetContext()
        {
            return _dbContext;
        }
    }
}
