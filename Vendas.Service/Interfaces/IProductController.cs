using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface IProductController
    {
        string Save(Product entity);
        string Exclude(Product entity);
        string Exclude(int id);
        List<Product> Filter(Expression<Func<Product, bool>> condition);

        List<Product> GetAll();

    }
}