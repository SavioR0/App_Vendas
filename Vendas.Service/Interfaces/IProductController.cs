using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface IProductController
    {
        string Save(Product entity);
        string Exclude(Product entity);
        string Exclude(int id);
        IQueryable<Product> Filter(Expression<Func<Product, bool>> condition);

        IQueryable<Product> GetAll();

    }
}