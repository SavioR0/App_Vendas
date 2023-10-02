using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Vendas.Repository.Intefaces
{
    interface IRepository<T> where T: class
    {
        DbContext GetContext();
        string Insert(T entity);
        string Update(T entity);
        string Delete(T entity);
        string Delete(int id);
        //IQueryable<T> Filter(Expression<System.Func<T, bool>> condition, params Expression<Func<T, object>>[] includes);
        IQueryable<T> Filter(Expression<System.Func<T, bool>> condition);
        List<T> GetAll();
        T GetById(int id);
        string SaveChanges();
    }
}
