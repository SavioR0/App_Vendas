using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface ITypeUsersController
    {
        List<TypeUsers> Filter(Expression<Func<TypeUsers, bool>> condition);
        List<TypeUsers> GetAll();
    }
}
