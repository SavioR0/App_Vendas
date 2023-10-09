using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface ISaleController
    {
        string Save(Sale entity);
        string Exclude(Sale entity);
        string Exclude(int id);
        List<Sale> Filter(Expression<Func<Sale, bool>> condition);
        List<Sale> GetAll();

    }
}