using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vendas.Repository.Interfaces
{
    public interface IDefaultRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        string Add(T entity);
        string Update(T entity);
        string Remove(T entity);
        List<T> Filter(Expression<System.Func<T, bool>> condition);
    }
}
