using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface ISaleController
    {
        string Save(Sale entity);
        string Exclude(Sale entity);
        string Exclude(int id);
        IQueryable<Sale> Filter(Expression<Func<Sale, bool>> condition);
        IQueryable<Sale> GetAll();

    }
}