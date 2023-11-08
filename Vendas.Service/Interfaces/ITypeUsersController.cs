using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface ITypeUsersController
    {
        IQueryable<TypeUsers> Filter(Expression<Func<TypeUsers, bool>> condition);
        IQueryable<TypeUsers> GetAll();
    }
}
