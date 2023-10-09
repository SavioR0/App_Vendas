using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Entity.Entities;
using Vendas.Infrastructure;
using Vendas.Repository.Intefaces;

namespace Vendas.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;
        private DbSet<T> DbSet
        {
            get { return _dbContext.Set<T>(); }}
        public Repository(DbContext context)
        {
            _dbContext = context;
        }

        public string Delete(T entity)
        {
            DbSet.Remove(Filter(c => c.Id == entity.Id).FirstOrDefault());
            //_dbSet.Remove(entity);
            return SaveChanges();
        }

        public string Delete(int id)
        {
            DbSet.Remove(Filter(c => c.Id == id).FirstOrDefault());
            return SaveChanges();
        }

        //public IQueryable<T> Filter(Expression<System.Func<T, bool>> condition, params Expression<Func<T, object>>[] includes)
        //{
        //    var query = _dbContext.Set<T>().Where(condition);
        //    foreach (var include in includes)
        //    {
        //        query = query.Include(include);
        //    }
        //    return query;
        //}
        public IQueryable<T> Filter(Expression<System.Func<T, bool>> condition)
        {
            return DbSet.Where(condition);
        }

        public List<T> GetAll()
        {
            return DbSet.ToList<T>();
        }

        public T GetById(int id)
        {
            return DbSet.Where(c => id == c.Id).FirstOrDefault();
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

        public string Insert(T entity)
        {
            DbSet.Add(entity);
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
    }
}
